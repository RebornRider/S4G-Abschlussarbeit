using UnityEngine;

namespace PaladinCharacter
{
    public abstract class ActorDriver : MonoBehaviour
    {
        [SerializeField]
        protected ActorMover mover;

        protected virtual void Awake()
        {
            mover = mover ?? GetComponent<ActorMover>();
        }

        protected virtual void OnValidate()
        {
            mover = mover ?? GetComponent<ActorMover>();
        }
    }
}