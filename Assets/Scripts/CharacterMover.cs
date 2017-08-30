using PaladinCharacter.Utility;
using System.Linq;
using UnityEngine;

namespace PaladinCharacter
{
    public class CharacterMover : ActorMover
    {
        [SerializeField]
        protected LayerMask GroundLayers;
        [SerializeField]
        protected float GroundDistance = 0.2f;
        [SerializeField]
        protected Transform GroundChecker;
        [SerializeField]
        protected AnimationCurve distanceToForwardMovementSpeed;

        private float smoothedIntednedVelocity;

        public Animator anim;

        public override void Dash(float dashDistance)
        {
            Vector3 dashVelocity = Vector3.Scale(transform.forward, dashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * Rb.drag + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * Rb.drag + 1)) / -Time.deltaTime)));
            Rb.AddForce(dashVelocity, ForceMode.VelocityChange);
        }

        public override void Jump(float jumpHeight)
        {
            Rb.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
        }

        public virtual void Update()
        {
            CheckGrounding();
        }

        private readonly RaycastHit[] results = new RaycastHit[16];
        private RaycastHit groundHit;
        public override void CheckGrounding()
        {
            int hitCount = Physics.SphereCastNonAlloc(GroundChecker.position + Vector3.up * 0.01f, 0.01f, Vector3.down, results, GroundDistance + 0.01f,
                GroundLayers.value, QueryTriggerInteraction.Ignore);
            if (hitCount > 0)
            {
                var distanceSortedColliders = results
                    .Take(hitCount)
                    .Where(hit => hit.transform != null && hit.transform.gameObject != gameObject &&
                                  (GroundChecker.position.y - hit.point.y) > 0)
                    .OrderBy(hit => GroundChecker.position.y - hit.point.y);
                isGrounded = distanceSortedColliders.Any();
                if (isGrounded)
                {
                    groundHit = distanceSortedColliders.First();
                }

                Debug.Log(hitCount);
                for (var i = 0; i < hitCount; i++)
                {
                    Debug.Log(i + ": " + results[i].transform.name + " | " + results[i].point + " | " + results[i].normal);
                    Debug.DrawRay(Rb.position, results[i].normal * 100, Color.magenta);
                }
                foreach (var raycastHit in results.Take(hitCount))
                {
                    Debug.DrawRay(Rb.position, raycastHit.normal * 100, Color.magenta);
                }
            }
            else
            {
                isGrounded = false;
            }


        }

        private Vector3 lastPos;
        private Quaternion lookRotation = Quaternion.identity;
        public virtual void FixedUpdate()
        {
            Vector3 moveDelta = IntendedVelocity * Time.fixedDeltaTime;
            float distance = Vector3.Distance(lastPos, transform.position);

            anim.SetFloat("ForwardMovementSpeed", distanceToForwardMovementSpeed.Evaluate(distance));
            CheckGrounding();

            if (Mathf.Abs(moveDelta.x) + Mathf.Abs(moveDelta.z) > 0.001)
            {
                int hitCount = Physics.RaycastNonAlloc(new Ray(GroundChecker.position + Vector3.up * 0.01f, Vector3.down), results,
                    GroundDistance + 0.01f, GroundLayers.value, QueryTriggerInteraction.Ignore);
                if (hitCount > 0)
                {
                    var distanceSortedColliders = results
                        .Take(hitCount)
                        .Where(hit => hit.transform != null && hit.transform.gameObject != gameObject &&
                                      (GroundChecker.position.y - hit.point.y) > 0)
                        .OrderBy(hit => GroundChecker.position.y - hit.point.y);

                    if (distanceSortedColliders.Any())
                    {
                        Rb.MovePosition(distanceSortedColliders.First().point);
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
                Debug.DrawRay(Rb.position, moveDelta * 100, Color.green);
            }

            if (IntendedVelocity.x0z().IsApproximatelyVectorZero() == false)
            {

                lookRotation = Quaternion.LookRotation(IntendedVelocity.x0z().normalized);

            }
            Rb.MoveRotation(lookRotation);

            lastPos = transform.position;
        }
    }

}