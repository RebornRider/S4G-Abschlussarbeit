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

        public virtual void Update()
        {
            mover.SetIntendedVelocity(GetIntendedVelocity());
        }
        public virtual Vector3 GetIntendedVelocity()
        {
            return Vector3.zero;
        }
    }
}