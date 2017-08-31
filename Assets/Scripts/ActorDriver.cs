using UnityEngine;

namespace PaladinCharacter
{
    public interface IActorDriver
    {

    }

    public abstract class ActorDriver<TInputSource, TCameraRig, TActorMover, TActorAnimator> : MonoBehaviour, IActorDriver
        where TInputSource : MonoBehaviour, IInputSource
        where TCameraRig : MonoBehaviour, ICameraRig
        where TActorMover : MonoBehaviour, IActorMover
        where TActorAnimator : MonoBehaviour, IActorAnimator
    {
        [SerializeField]
        protected TActorMover Mover;
        [SerializeField]
        protected TCameraRig CameraRig;
        [SerializeField]
        protected TInputSource InputSource;
        [SerializeField]
        protected TActorAnimator Animator;

        protected virtual void Awake()
        {
            Mover = Mover ?? GetComponent<TActorMover>();
            InputSource = InputSource ?? GetComponent<TInputSource>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }

        protected virtual void OnValidate()
        {
            Mover = Mover ?? GetComponent<TActorMover>();
            InputSource = InputSource ?? GetComponent<TInputSource>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }
    }
}