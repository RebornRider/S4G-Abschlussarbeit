using UnityEngine;

namespace PaladinCharacter
{
    public abstract class ActorDriver : MonoBehaviour
    {
        [SerializeField]
        protected ActorMover Mover;
        [SerializeField]
        protected CameraRig CameraRig;

        protected virtual void Awake()
        {
            Mover = Mover ?? GetComponent<ActorMover>();
        }

        protected virtual void OnValidate()
        {
            Mover = Mover ?? GetComponent<ActorMover>();
        }
    }
}