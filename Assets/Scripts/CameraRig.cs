using UnityEngine;

namespace PaladinCharacter
{
    public abstract class CameraRig : MonoBehaviour
    {
        [SerializeField]
        protected Transform Anchor;

        /// <summary>
        /// Offset from the anchor that the camera will be positioned
        /// </summary>
        [SerializeField]
        protected Vector3 anchorOffset = new Vector3(0f, 2f, 0f);

        public abstract Vector3 Forward { get; }

    }
}