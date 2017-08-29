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
                mover.SetIntendedVelocity(GetIntendedVelocity());
            }

            mover.CheckGrounding();
            if (Input.GetKeyDown(KeyCode.LeftShift) && mover.IsGrounded)
            {
                mover.Dash(DashDistance);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                mover.Jump(JumpHeight);
            }
        }

        protected Vector3 GetIntendedVelocity()
        {
            mover.CheckGrounding();
            if (mover.IsGrounded)
            {
                return new Vector3(Input.GetAxis("Horizontal") * forwardSpeed, 0, Input.GetAxis("Vertical") * sidewardSpeed);
            }
            else
            {
                return Vector3.down * FallSpeed;
            }
        }
    }
}
