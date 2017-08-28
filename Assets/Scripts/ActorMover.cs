using UnityEngine;

namespace PaladinCharacter
{
    public abstract class ActorMover : MonoBehaviour
    {
        [SerializeField]
        protected CharacterController characterController;

        protected virtual void Awake()
        {
            characterController = characterController ?? GetComponent<CharacterController>();
        }

        protected virtual void OnValidate()
        {
            characterController = characterController ?? GetComponent<CharacterController>();
        }

        public abstract void SetIntendedVelocity(Vector3 intendedVelocity);
    }
}