using PaladinCharacter.Utility;
using System.Linq;
using UnityEngine;

namespace PaladinCharacter
{
    public class CharacterMover : ActorMover<PaladinAnimator>
    {
        [SerializeField]
        protected LayerMask GroundLayers;
        [SerializeField]
        protected float GroundDistance = 0.2f;
        [SerializeField]
        protected float GroundSphereRadius = 0.4f;
        [SerializeField]
        protected Transform GroundChecker;

        public void Dash(float dashDistance)
        {
            Vector3 dashVelocity = Vector3.Scale(transform.forward, dashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * Rb.drag + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * Rb.drag + 1)) / -Time.deltaTime)));
            Rb.AddForce(dashVelocity, ForceMode.VelocityChange);
        }

        public void Jump(float jumpHeight)
        {
            Rb.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
            Animator.JumpHandler();
        }

        public virtual void Update()
        {
            CheckGrounding();
        }

        private readonly RaycastHit[] results = new RaycastHit[16];
        private RaycastHit groundHit;
        public override void CheckGrounding()
        {
            if (HandleGroundCheckResult(CheckGroundSimple()))
            {
                return;
            }

            if (HandleGroundCheckResult(CheckGroundComplex()))
            {
                return;
            }

        }

        private bool HandleGroundCheckResult(GroundCheckResult result)
        {
            isGrounded = result.RaycastHitAnything && result.IsGrounded;

            if (isGrounded)
            {
                groundHit = result.GroundHit;
                Debug.DrawRay(groundHit.point, groundHit.normal * 10);
            }

            return result.RaycastHitAnything;
        }

        private GroundCheckResult CheckGroundSimple()
        {
            int hitCount = Physics.RaycastNonAlloc(new Ray(GroundChecker.position + Vector3.up * 0.01f, Vector3.down),
                results,
                GroundDistance + 0.01f, GroundLayers.value, QueryTriggerInteraction.Ignore);
            if (hitCount > 0)
            {
                IOrderedEnumerable<RaycastHit> distanceSortedColliders = results
                    .Take(hitCount)
                    .Where(hit => hit.transform != null && hit.transform.gameObject != gameObject &&
                                  hit.collider.isTrigger == false &&
                                  (GroundChecker.position.y - hit.point.y) > 0)
                    .OrderBy(hit => GroundChecker.position.y - hit.point.y);

                bool grounded = distanceSortedColliders.Any();
                return new GroundCheckResult(hitCount, grounded,
                    grounded ? distanceSortedColliders.First() : new RaycastHit());
            }

            return new GroundCheckResult(hitCount, false, new RaycastHit());
        }

        private GroundCheckResult CheckGroundComplex()
        {
            Vector3 sphereTarget = GroundChecker.position + Vector3.up * GroundSphereRadius;
            Vector3 sphereOrigin = sphereTarget + Vector3.up * GroundSphereRadius;
            int sphereHitCount = Physics.SphereCastNonAlloc(new Ray(sphereOrigin, Vector3.down), GroundSphereRadius, results, GroundSphereRadius + 0.01f, GroundLayers.value, QueryTriggerInteraction.Ignore);
            if (sphereHitCount > 0)
            {
                IOrderedEnumerable<RaycastHit> distanceSortedColliders = results
                    .Take(sphereHitCount)
                    .Where(hit => hit.transform != null && hit.transform.gameObject != gameObject &&
                                  hit.collider.isTrigger == false &&
                                  (sphereTarget.y - hit.point.y) > 0)
                    .OrderBy(hit => sphereTarget.y - hit.point.y);

                bool grounded = distanceSortedColliders.Any();
                return new GroundCheckResult(sphereHitCount, grounded,
                    grounded ? distanceSortedColliders.First() : new RaycastHit());
            }

            return new GroundCheckResult(sphereHitCount, false, new RaycastHit());
        }

        private Vector3 lastPos;
        private Quaternion lookRotation = Quaternion.identity;
        public virtual void FixedUpdate()
        {
            float distance = Vector3.Distance(lastPos, transform.position);
            Animator.SetMovementDistance(distance);

            CheckGrounding();

            Vector3 moveDelta = IntendedVelocity * Time.fixedDeltaTime;
            if (moveDelta.sqrMagnitude > 0.001)
            {

                if (isGrounded == false)
                {
                    var groundCheckResult = CheckGroundSimple();
                    if (groundCheckResult.RaycastHitAnything && groundCheckResult.IsGrounded)
                    {
                        Rb.MovePosition(groundCheckResult.GroundHit.point);
                    }
                }

                if (isGrounded)
                {
                    moveDelta = Vector3.ProjectOnPlane(moveDelta, groundHit.normal);
                }

                Rb.velocity += moveDelta;
                Debug.DrawRay(Rb.position, moveDelta * 100, Color.red);
            }
            else
            {
                if (isGrounded == false)
                {
                    Debug.Log(moveDelta);
                }
                Rb.velocity += moveDelta;
                Debug.DrawRay(Rb.position, moveDelta * 100, Color.green);
            }

            if (IntendedVelocity.x0z().IsApproximatelyVectorZero() == false)
            {

                lookRotation = Quaternion.LookRotation(IntendedVelocity.x0z().normalized);

            }
            Rb.MoveRotation(lookRotation);
            Animator.SetGrounding(isGrounded);

            lastPos = transform.position;
        }

        protected struct GroundCheckResult
        {
            public readonly bool RaycastHitAnything;
            public readonly bool IsGrounded;
            public readonly RaycastHit GroundHit;

            public GroundCheckResult(int hitCount, bool onGroung, RaycastHit groundHit) : this()
            {
                RaycastHitAnything = hitCount > 0;
                IsGrounded = onGroung;
                GroundHit = groundHit;
            }
        }
    }
}