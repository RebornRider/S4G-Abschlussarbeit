// file:	Assets\PaladinCharacter\Scripts\CharacterDriver.cs
//
// summary:	Implements the character driver class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   Interface for character driver. </summary>
    public interface ICharacterDriver
    {
    }

    /// <summary>   A character driver. </summary>
    /// <typeparam name="TInputSource">     Type of the input source. </typeparam>
    /// <typeparam name="TCameraRig">       Type of the camera rig. </typeparam>
    /// <typeparam name="TActorMover">      Type of the actor mover. </typeparam>
    /// <typeparam name="TActorAnimator">   Type of the actor animator. </typeparam>
    public abstract class
        CharacterDriver<TInputSource, TCameraRig, TActorMover, TActorAnimator> :
            PawnDriver<TInputSource, TActorMover, TActorAnimator>, ICharacterDriver
        where TInputSource : MonoBehaviour, IInputSource
        where TCameraRig : MonoBehaviour, ICameraRig
        where TActorMover : MonoBehaviour, IActorMover
        where TActorAnimator : MonoBehaviour, IActorAnimator
    {
        /// <summary>   The camera rig. </summary>
        [SerializeField]
        protected TCameraRig CameraRig;
    }
}