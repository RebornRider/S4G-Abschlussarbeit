// file:	Assets\PaladinCharacter\Scripts\CameraRig.cs
//
// summary:	Implements the camera rig class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   Interface for camera rig. </summary>
    public interface ICameraRig
    {
    }

    /// <summary>   A camera rig. </summary>
    /// <typeparam name="TInputSource"> Type of the input source. </typeparam>
    public abstract class CameraRig<TInputSource> : MonoBehaviour, ICameraRig
        where TInputSource : MonoBehaviour, IInputSource
    {
        /// <summary>   The anchor. </summary>
        [SerializeField]
        protected Transform Anchor;

        /// <summary>   Offset from the anchor that the camera will be positioned. </summary>
        [SerializeField]
        protected Vector3 AnchorOffset = new Vector3(0f, 2f, 0f);

        /// <summary>   The input source. </summary>
        [SerializeField]
        protected TInputSource InputSource;

        /// <summary>   Gets the offsetted anchor position. </summary>
        /// <value> The offsetted anchor position. </value>
        protected Vector3 OffsettedAnchorPosition
        {
            get { return Anchor.position + Anchor.rotation * AnchorOffset; }
        }

        /// <summary>   Awakes this object. </summary>
        protected virtual void Awake()
        {
            InputSource = InputSource ?? GetComponent<TInputSource>();
        }

        /// <summary>   Executes the validate action. </summary>
        protected virtual void OnValidate()
        {
            InputSource = InputSource ?? GetComponent<TInputSource>();
        }
    }
}