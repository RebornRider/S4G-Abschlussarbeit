using PaladinCharacter.Utility;
using UnityEngine;

namespace PaladinCharacter
{
    public class PaladinDriver : ActorDriver<PaladinInput, ThirdPersonCamera, CharacterMover>
    {
        [SerializeField]
        private float forwardSpeed = 1;
        [SerializeField]
        private float sidewardSpeed = 1;
        [SerializeField]
        protected PaladinAnimator Animator;

        public float JumpHeight = 2f;
        public float DashDistance = 5f;
        public float FallSpeed = 50;

        public void Update()
        {
            if (InputSource.GetMovementTwoAxis().IsApproximatelyVectorZero() == false)
            {
                Mover.SetIntendedVelocity(GetIntendedVelocity());
            }
            else
            {
                Mover.SetIntendedVelocity(Vector3.zero);
            }

            Mover.CheckGrounding();
            if (InputSource.WasDashPressed() && Mover.IsGrounded)
            {
                Mover.Dash(DashDistance);
            }
            if (InputSource.WasJumpPressed())
            {
                Mover.Jump(JumpHeight);
            }
        }

        protected Vector3 GetIntendedVelocity()
        {
            Mover.CheckGrounding();
            if (Mover.IsGrounded)
            {
                var forwardMovement = Vector3.ProjectOnPlane(CameraRig.transform.forward * InputSource.GetMovementTwoAxis().y * forwardSpeed, Vector3.up);
                var sidewardsMovement = Vector3.ProjectOnPlane(CameraRig.transform.right * InputSource.GetMovementTwoAxis().x * sidewardSpeed, Vector3.up);

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
