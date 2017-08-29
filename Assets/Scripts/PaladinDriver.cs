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
                var planarDirectionInCameraSpace = Vector3.ProjectOnPlane(CameraRig.transform.TransformDirection(new Vector3(
                    Input.GetAxis("Horizontal"), 0,
                    Input.GetAxis("Vertical"))), Vector3.up).normalized;

                planarDirectionInCameraSpace.x *= forwardSpeed;
                planarDirectionInCameraSpace.z *= sidewardSpeed;

                return planarDirectionInCameraSpace;
            }
            else
            {
                return Vector3.down * FallSpeed;
            }
        }
    }
}
