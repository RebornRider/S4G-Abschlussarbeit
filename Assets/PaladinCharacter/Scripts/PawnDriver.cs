// file:	Assets\PaladinCharacter\Scripts\PawnDriver.cs
//
// summary:	Implements the pawn driver class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   Interface for pawn driver. </summary>
    public interface IPawnDriver
    {
    }

    /// <summary>   A pawn driver. </summary>
    /// <typeparam name="TInputSource">     Type of the input source. </typeparam>
    /// <typeparam name="TActorMover">      Type of the actor mover. </typeparam>
    /// <typeparam name="TActorAnimator">   Type of the actor animator. </typeparam>
    public abstract class PawnDriver<TInputSource, TActorMover, TActorAnimator> : Actor, IPawnDriver
        where TInputSource : MonoBehaviour, IInputSource
        where TActorMover : MonoBehaviour, IActorMover
        where TActorAnimator : MonoBehaviour, IActorAnimator
    {
        /// <summary>   The animator. </summary>
        [SerializeField]
        protected TActorAnimator Animator;

        /// <summary>   The input source. </summary>
        [SerializeField]
        protected TInputSource InputSource;

        /// <summary>   The mover. </summary>
        [SerializeField]
        protected TActorMover Mover;


        /// <summary>   Awakes this object. </summary>
        protected virtual void Awake()
        {
            Mover = Mover ?? GetComponent<TActorMover>();
            InputSource = InputSource ?? GetComponent<TInputSource>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }

        /// <summary>   Executes the validate action. </summary>
        protected virtual void OnValidate()
        {
            Mover = Mover ?? GetComponent<TActorMover>();
            InputSource = InputSource ?? GetComponent<TInputSource>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }
    }
}