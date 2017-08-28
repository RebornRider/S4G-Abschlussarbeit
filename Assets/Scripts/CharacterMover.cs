using UnityEngine;

namespace PaladinCharacter
{
    public class CharacterMover : ActorMover
    {
        protected Vector3 intendedVelocity;

        public override void SetIntendedVelocity(Vector3 intendedVelocity)
        {
            this.intendedVelocity = intendedVelocity;
        }

        public virtual void Update()
        {

        }

        public virtual void FixedUpdate()
        {
            Vector3 moveDirection = intendedVelocity;
            if (characterController.isGrounded == false)
            {
                moveDirection += Physics.gravity;
            }
            var collisionFlags = characterController.Move(moveDirection);
        }
    }
}