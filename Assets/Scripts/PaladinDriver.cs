using PaladinCharacter.Utility;
using UnityEngine;

namespace PaladinCharacter
{
    public class PaladinDriver : ActorDriver
    {
        [SerializeField]
        private float forwardSpeed = 1;
        [SerializeField]
        private float sidewardSpeed = 1;

        public float JumpHeight = 2f;
        public float DashDistance = 5f;
        public float FallSpeed = 50;

        public void Update()
        {

            Vector3 inputs = Vector3.zero;
            inputs.x = Input.GetAxis("Horizontal");
            inputs.z = Input.GetAxis("Vertical");

            if (inputs.IsApproximatelyVectorZero() == false)
            {
                Mover.SetIntendedVelocity(GetIntendedVelocity());
            }
            else
            {
                Mover.SetIntendedVelocity(Vector3.zero);
            }

            Mover.CheckGrounding();
            if (Input.GetKeyDown(KeyCode.LeftShift) && Mover.IsGrounded)
            {
                Mover.Dash(DashDistance);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Mover.Jump(JumpHeight);
            }
        }

        protected Vector3 GetIntendedVelocity()
        {
            Mover.CheckGrounding();
            if (Mover.IsGrounded)
            {
                var forwardMovement = Vector3.ProjectOnPlane(CameraRig.transform.forward * Input.GetAxis("Vertical") * forwardSpeed, Vector3.up);
                var sidewardsMovement = Vector3.ProjectOnPlane(CameraRig.transform.right * Input.GetAxis("Horizontal") * sidewardSpeed, Vector3.up);

                Vector3 movementDirection = Vector3.Lerp(forwardMovement, sidewardsMovement, 0.5f);
                Debug.DrawRay(transform.position, movementDirection, Color.cyan);

                return movementDirection;
            }
            else
            {
                return Vector3.down * FallSpeed;
            }
        }
    }
}
