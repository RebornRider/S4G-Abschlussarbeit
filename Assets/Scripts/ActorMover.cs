using UnityEngine;

namespace PaladinCharacter
{
    public abstract class ActorMover : MonoBehaviour
    {
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
        }

        protected virtual void OnValidate()
        {
            Rb = Rb ?? GetComponent<Rigidbody>();
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