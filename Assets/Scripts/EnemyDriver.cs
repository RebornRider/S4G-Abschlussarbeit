using UnityEngine;

namespace PaladinCharacter
{
    public class EnemyDriver : ActorDriver<InputSourceStub, ActorMoverStub, EnemyAnimator>, IHittable
    {
        [SerializeField]
        private float fallSpeed = 50.0f;

        public void Update()
        {
            if (Animator.HitBehaviour.IsHit == false)
            {
                Mover.SetIntendedVelocity(Vector3.zero);
            }
            else
            {
                Mover.SetIntendedVelocity(GetIntendedVelocity());
            }
        }

        protected Vector3 GetIntendedVelocity()
        {
            Mover.CheckGrounding();
            if (Mover.IsGrounded)
            {
                return Vector3.zero;
            }
            else
            {
                return Vector3.down * fallSpeed;
            }
        }

        public void HitHandler()
        {
            Animator.HitHandler();
        }
    }

    public interface IHittable
    {
        void HitHandler();
    }
}