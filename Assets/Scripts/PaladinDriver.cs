using UnityEngine;

namespace PaladinCharacter
{
    public class PaladinDriver : ActorDriver
    {
        [SerializeField]
        private float forwardSpeed = 1;
        [SerializeField]
        private float sidewardSpeed = 1;

        public override void Update()
        {
            // other stuf

            base.Update();
        }

        public override Vector3 GetIntendedVelocity()
        {
            return new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * forwardSpeed, 0, Input.GetAxis("Vertical") * Time.deltaTime * sidewardSpeed);
        }
    }
}
