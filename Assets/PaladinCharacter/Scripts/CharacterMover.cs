// file:	Assets\PaladinCharacter\Scripts\CharacterMover.cs
//
// summary:	Implements the character mover class

using PaladinCharacter.Utility;
using System.Linq;
using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   A character mover. </summary>
    public class CharacterMover : ActorMover<PaladinAnimator>
    {
        /// <summary>   The results. </summary>
        private readonly RaycastHit[] results = new RaycastHit[16];

        /// <summary>   The ground checker. </summary>
        [SerializeField]
        protected Transform GroundChecker;

        /// <summary>   The ground distance. </summary>
        [SerializeField]
        protected float GroundDistance = 0.2f;

        /// <summary>   The ground hit. </summary>
        private RaycastHit groundHit;

        /// <summary>   The ground layers. </summary>
        [SerializeField]
        protected LayerMask GroundLayers;

        /// <summary>   The ground sphere radius. </summary>
        [SerializeField]
        protected float GroundSphereRadius = 0.4f;

        /// <summary>   The last position. </summary>
        private Vector3 lastPos;

        /// <summary>   The look rotation. </summary>
        private Quaternion lookRotation = Quaternion.identity;

        /// <summary>   Dashes. </summary>
        /// <param name="dashDistance"> The dash distance. </param>
        public void Dash(float dashDistance)
        {
            Vector3 dashVelocity = Vector3.Scale(transform.forward,
                dashDistance * new Vector3(Mathf.Log(1f / (Time.deltaTime * Rb.drag + 1)) / -Time.deltaTime, 0,
                    Mathf.Log(1f / (Time.deltaTime * Rb.drag + 1)) / -Time.deltaTime));
            Rb.AddForce(dashVelocity, ForceMode.VelocityChange);
        }

        /// <summary>   Jumps. </summary>
        /// <param name="jumpHeight">   Height of the jump. </param>
        public void Jump(float jumpHeight)
        {
            Rb.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
            Animator.JumpHandler();
        }

        /// <summary>   Updates this object. </summary>
        public virtual void Update()
        {
            CheckGrounding();
        }

        /// <summary>   Check grounding. </summary>
        public override void CheckGrounding()
        {
            if (HandleGroundCheckResult(CheckGroundSimple()))
            {
                return;
            }
            HandleGroundCheckResult(CheckGroundComplex());
        }

        /// <summary>   Handles the ground check result described by result. </summary>
        /// <param name="result">   The result. </param>
        /// <returns>   True if it succeeds, false if it fails. </returns>
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

        /// <summary>   Check ground simple. </summary>
        /// <returns>   A GroundCheckResult. </returns>
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
                                  GroundChecker.position.y - hit.point.y > 0)
                    .OrderBy(hit => GroundChecker.position.y - hit.point.y);

                bool grounded = distanceSortedColliders.Any();
                return new GroundCheckResult(hitCount, grounded,
                    grounded ? distanceSortedColliders.First() : new RaycastHit());
            }

            return new GroundCheckResult(hitCount, false, new RaycastHit());
        }

        /// <summary>   Check ground complex. </summary>
        /// <returns>   A GroundCheckResult. </returns>
        private GroundCheckResult CheckGroundComplex()
        {
            Vector3 sphereTarget = GroundChecker.position + Vector3.up * GroundSphereRadius;
            Vector3 sphereOrigin = sphereTarget + Vector3.up * GroundSphereRadius;
            int sphereHitCount = Physics.SphereCastNonAlloc(new Ray(sphereOrigin, Vector3.down), GroundSphereRadius,
                results, GroundSphereRadius + 0.01f, GroundLayers.value, QueryTriggerInteraction.Ignore);
            if (sphereHitCount > 0)
            {
                IOrderedEnumerable<RaycastHit> distanceSortedColliders = results
                    .Take(sphereHitCount)
                    .Where(hit => hit.transform != null && hit.transform.gameObject != gameObject &&
                                  hit.collider.isTrigger == false &&
                                  sphereTarget.y - hit.point.y > 0)
                    .OrderBy(hit => sphereTarget.y - hit.point.y);

                bool grounded = distanceSortedColliders.Any();
                return new GroundCheckResult(sphereHitCount, grounded,
                    grounded ? distanceSortedColliders.First() : new RaycastHit());
            }

            return new GroundCheckResult(sphereHitCount, false, new RaycastHit());
        }

        /// <summary>   Fixed update. </summary>
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
                    GroundCheckResult groundCheckResult = CheckGroundSimple();
                    if (groundCheckResult.RaycastHitAnything && groundCheckResult.IsGrounded)
                    {
                        Rb.MovePosition(groundCheckResult.GroundHit.point);
                        CheckGrounding();
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

        /// <summary>   Encapsulates the result of a ground check. </summary>
        protected struct GroundCheckResult
        {
            /// <summary>   True if the raycast hit anything. </summary>
            public readonly bool RaycastHitAnything;

            /// <summary>   True if this object is grounded. </summary>
            public readonly bool IsGrounded;

            /// <summary>   The ground hit. </summary>
            public readonly RaycastHit GroundHit;

            /// <summary>   Constructor. </summary>
            /// <param name="hitCount">     Number of hits. </param>
            /// <param name="onGround">     True to on ground. </param>
            /// <param name="groundHit">    The ground hit. </param>
            public GroundCheckResult(int hitCount, bool onGround, RaycastHit groundHit) : this()
            {
                RaycastHitAnything = hitCount > 0;
                IsGrounded = onGround;
                GroundHit = groundHit;
            }
        }
    }
}