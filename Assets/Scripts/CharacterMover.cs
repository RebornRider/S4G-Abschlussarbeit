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

        public override void CheckGrounding()
        {
            isGrounded = Physics.CheckSphere(GroundChecker.position, GroundDistance, GroundLayers, QueryTriggerInteraction.Ignore);
        }

        private Vector3 lastPos;
        public virtual void FixedUpdate()
        {
            Vector3 moveDelta = IntendedVelocity * Time.fixedDeltaTime;
            if (Mathf.Abs(moveDelta.x) + Mathf.Abs(moveDelta.z) > 0.001)
            {
                Rb.velocity += moveDelta;
                Debug.DrawRay(Rb.position, moveDelta * 100, Color.red);
            }
            else
            {
                Debug.DrawRay(Rb.position, moveDelta * 100, Color.green);
            }

            //Rb.MovePosition(Rb.position + moveDelta);
            Vector3 movementDirection = Vector3.ProjectOnPlane(IntendedVelocity, Vector3.up);
            if (movementDirection.IsApproximatelyVectorZero() == false)
            {
                Rb.MoveRotation(Quaternion.LookRotation(movementDirection));
            }

            float distance = Vector3.Distance(lastPos, transform.position);
            anim.SetFloat("ForwardMovementSpeed", distanceToForwardMovementSpeed.Evaluate(distance));
            lastPos = transform.position;
        }
    }

}