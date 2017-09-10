// file:	Assets\PaladinCharacter\Scripts\ActorMover.cs
//
// summary:	Implements the actor mover class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   Interface for actor mover. </summary>
    public interface IActorMover
    {
    }

    /// <summary>   An actor mover. </summary>
    /// <typeparam name="TActorAnimator">   Type of the actor animator. </typeparam>
    public abstract class ActorMover<TActorAnimator> : MonoBehaviour, IActorMover
        where TActorAnimator : MonoBehaviour, IActorAnimator
    {
        /// <summary>   The ActorAnimator. </summary>
        [SerializeField]
        protected TActorAnimator Animator;

        /// <summary>   The intended velocity. </summary>
        protected Vector3 IntendedVelocity;

        /// <summary>   True if this object is grounded. </summary>
        protected bool isGrounded = true;

        /// <summary>   The Rigidbody. </summary>
        [SerializeField]
        protected Rigidbody Rb;

        /// <summary>   Gets a value indicating whether this object is grounded. </summary>
        /// <value> True if this object is grounded, false if not. </value>
        public bool IsGrounded
        {
            get { return isGrounded; }
        }

        /// <summary>   Awakes this object. </summary>
        protected virtual void Awake()
        {
            Rb = Rb ?? GetComponent<Rigidbody>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }

        /// <summary>   Executes the validate action. </summary>
        protected virtual void OnValidate()
        {
            Rb = Rb ?? GetComponent<Rigidbody>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }

        /// <summary>   Sets intended velocity. </summary>
        /// <param name="intendedVelocity"> The intended velocity. </param>
        public virtual void SetIntendedVelocity(Vector3 intendedVelocity)
        {
            IntendedVelocity = intendedVelocity;
        }

        /// <summary>   Checks grounding. </summary>
        public abstract void CheckGrounding();
    }
}