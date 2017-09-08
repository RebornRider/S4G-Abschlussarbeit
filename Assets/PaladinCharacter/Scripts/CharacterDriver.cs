using UnityEngine;

namespace PaladinCharacter
{
    public interface ICharacterDriver
    {

    }

    public abstract class CharacterDriver<TInputSource, TCameraRig, TActorMover, TActorAnimator> : PawnDriver<TInputSource, TActorMover, TActorAnimator>, ICharacterDriver
        where TInputSource : MonoBehaviour, IInputSource
        where TCameraRig : MonoBehaviour, ICameraRig
        where TActorMover : MonoBehaviour, IActorMover
        where TActorAnimator : MonoBehaviour, IActorAnimator
    {
        [SerializeField]
        protected TCameraRig CameraRig;
    }
}