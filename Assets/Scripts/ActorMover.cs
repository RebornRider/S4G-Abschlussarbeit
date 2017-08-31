using UnityEngine;

namespace PaladinCharacter
{
    public interface IActorMover
    {

    }

    public abstract class ActorMover<TActorAnimator> : MonoBehaviour, IActorMover
        where TActorAnimator : MonoBehaviour, IActorAnimator
    {
        [SerializeField]
        protected TActorAnimator Animator;
        [SerializeField]
        protected Rigidbody Rb;

        protected bool isGrounded = true;
        protected Vector3 IntendedVelocity;
        public bool IsGrounded
        {
            get { return isGrounded; }
        }

        protected virtual void Awake()
        {
            Rb = Rb ?? GetComponent<Rigidbody>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }

        protected virtual void OnValidate()
        {
            Rb = Rb ?? GetComponent<Rigidbody>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }

        public virtual void SetIntendedVelocity(Vector3 intendedVelocity)
        {
            IntendedVelocity = intendedVelocity;
        }

        public abstract void Dash(float dashDistance);
        public abstract void Jump(float jumpHeight);
        public abstract void CheckGrounding();
    }
}