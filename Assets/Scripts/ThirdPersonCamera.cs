using UnityEngine;

namespace PaladinCharacter
{
    public class ThirdPersonCamera : CameraRig
    {
        // Keep us from going past the poles
        private const float MIN_PITCH = 10f;
        private const float MAX_PITCH = 170f;

        /// <summary>
        /// Radius of the orbit
        /// </summary>
        [SerializeField]
        private float radius = 4f;


        /// <summary>
        /// Speed we'll actually apply to the rotation. This is essencially the
        /// number of degrees per tick assuming we're running at 60 FPS
        /// </summary>
        [SerializeField]
        private float degreesPerSecond = 1f;

        /// <summary>
        /// Determines if we invert the pitch information we get from the input
        /// </summary>
        [SerializeField]
        private bool invertPitch = true;


        /// <summary>
        /// Represents the "pole" that the camera is attched to the anchor with. This pole
        /// is the direction from the anchor to the camera (in natural "up" space)
        /// </summary>
        private Vector3 toCameraDirection = Vector3.back;

        /// <summary>
        /// We keep track of the tilt so we can make small changes to it as the actor rotates.
        /// This is safter than trying to do a full rotation all at once which can cause odd
        /// rotations as we hit 180 degrees.
        /// </summary>
        private Quaternion tilt = Quaternion.identity;


        public override Vector3 Forward
        {
            get { return transform.forward; }
        }


        public void LateUpdate()
        {
            Vector3 ofsettedAnchorPosition = Anchor.position + (Anchor.rotation * anchorOffset);
            Vector3 newCameraPosition = transform.position;
            Quaternion newCameraRotation = transform.rotation;

            //if (mInputSource.IsViewingActivated)
            // Grab the rotation amount. We do the inverse tilt so we calculate the rotation in
            // "natural up" space. Later we'll use the tilt to put it back into "anchor up" space.
            Quaternion lInvTilt = QuaternionExtensions.FromToRotation(Anchor.up, Vector3.up);

            // Yaw is simple as we can go 360
            Quaternion lYaw = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * degreesPerSecond,
                lInvTilt * transform.up);

            // Pitch is more complicated since we can't go beyond the north/south pole
            float lPitchAngle = Vector3.Angle(toCameraDirection, lInvTilt * Anchor.up);

            float lPitchDelta = (invertPitch ? -1f : 1f) * Input.GetAxis("Mouse Y");
            if (lPitchAngle < MIN_PITCH && lPitchDelta > 0f)
            {
                lPitchDelta = 0f;
            }
            else if (lPitchAngle > MAX_PITCH && lPitchDelta < 0f)
            {
                lPitchDelta = 0f;
            }

            Quaternion lPitch = Quaternion.AngleAxis(lPitchDelta, lInvTilt * transform.right);

            // Calculate the new "natural up" direction
            toCameraDirection = lPitch * lYaw * toCameraDirection;
            // end if

            // Update our tilt to match the anchor's tilt
            tilt = QuaternionExtensions.FromToRotation(tilt.Up(), Anchor.up) * tilt;

            // Put the new direction relative to the anchor's tilt
            Vector3 lToCameraDirection = tilt * toCameraDirection;
            if (lToCameraDirection.IsApproximatelyVectorZero())
            {
                lToCameraDirection = -Anchor.forward;
            }

            // Calculate the new orbit center (anchor) and camera position
            newCameraPosition = ofsettedAnchorPosition + (lToCameraDirection.normalized * radius);
            newCameraRotation = Quaternion.LookRotation(ofsettedAnchorPosition - newCameraPosition, Anchor.up);


            // Set the values
            transform.position = newCameraPosition;
            transform.rotation = newCameraRotation;
        }
    }
}
