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

        public virtual void FixedUpdate()
        {
            Rb.MovePosition(Rb.position + IntendedVelocity * Time.fixedDeltaTime);
            Vector3 movementDirection = Vector3.ProjectOnPlane(IntendedVelocity, Vector3.up);
            if (movementDirection.IsApproximatelyVectorZero() == false)
            {
                Rb.MoveRotation(Quaternion.LookRotation(movementDirection));
            }
        }
    }

}