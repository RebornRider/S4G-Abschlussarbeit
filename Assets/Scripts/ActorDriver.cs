using UnityEngine;

namespace PaladinCharacter
{
    public abstract class ActorDriver : MonoBehaviour
    {
        [SerializeField]
        protected ActorMover Mover;
        [SerializeField]
        protected CameraRig CameraRig;
        [SerializeField]
        protected InputSource InputSource;

        protected virtual void Awake()
        {
            InputSource = InputSource ?? GetComponent<InputSource>();
        }

        protected virtual void OnValidate()
        {
            InputSource = InputSource ?? GetComponent<InputSource>();
        }
    }
}