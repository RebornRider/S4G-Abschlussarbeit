using UnityEngine;

namespace PaladinCharacter
{
    public interface IActorDriver
    {

    }

    public abstract class ActorDriver<TInputSource, TCameraRig, TActorMover> : MonoBehaviour, IActorDriver
        where TInputSource : MonoBehaviour, IInputSource
        where TCameraRig : MonoBehaviour, ICameraRig
        where TActorMover : MonoBehaviour, IActorMover
    {
        [SerializeField]
        protected TActorMover Mover;
        [SerializeField]
        protected TCameraRig CameraRig;
        [SerializeField]
        protected TInputSource InputSource;

        protected virtual void Awake()
        {
            InputSource = InputSource ?? GetComponent<TInputSource>();
        }

        protected virtual void OnValidate()
        {
            InputSource = InputSource ?? GetComponent<TInputSource>();
        }
    }
}