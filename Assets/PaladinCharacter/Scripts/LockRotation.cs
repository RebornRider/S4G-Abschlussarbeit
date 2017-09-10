// file:	Assets\PaladinCharacter\Scripts\LockRotation.cs
//
// summary:	Implements the lock rotation class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   A lock rotation. </summary>
    public class LockRotation : MonoBehaviour
    {
        /// <summary>   The rotation. </summary>
        private Quaternion rotation;

        /// <summary>   Awakes this object. </summary>
        private void Awake()
        {
            rotation = transform.rotation;
        }

        /// <summary>   Updates this object. </summary>
        private void Update()
        {
            transform.rotation = rotation;
        }

        /// <summary>   Fixed update. </summary>
        private void FixedUpdate()
        {
            transform.rotation = rotation;
        }

        /// <summary>   Late update. </summary>
        private void LateUpdate()
        {
            transform.rotation = rotation;
        }
    }
}