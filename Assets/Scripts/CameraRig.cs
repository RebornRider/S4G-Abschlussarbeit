using UnityEngine;

namespace PaladinCharacter
{
    public interface ICameraRig
    {

    }

    public abstract class CameraRig<TInputSource> : MonoBehaviour, ICameraRig
        where TInputSource : MonoBehaviour, IInputSource
    {
        [SerializeField]
        protected TInputSource InputSource;
        [SerializeField]
        protected Transform Anchor;
        /// <summary>
        /// Offset from the anchor that the camera will be positioned
        /// </summary>
        [SerializeField]
        protected Vector3 AnchorOffset = new Vector3(0f, 2f, 0f);

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