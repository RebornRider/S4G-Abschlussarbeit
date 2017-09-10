// file:	Assets\PaladinCharacter\Scripts\ThirdPersonCamera.cs
//
// summary:	Implements the third person camera class

using PaladinCharacter.Utility;
using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   A third person camera. </summary>
    public class ThirdPersonCamera : CameraRig<ThirdPersonCameraInput>
    {
        /// <summary>
        ///     Speed we'll actually apply to the rotation. This is essentially the number of
        ///     degrees per tick assuming we're running at 60 FPS.
        /// </summary>
        [SerializeField]
        private float degreesPerTick = 1f;

        /// <summary>   Determines if we invert the pitch information we get from the input. </summary>
        [SerializeField]
        private bool invertPitch = true;

        /// <summary>   Keep us from going past the north pole. </summary>
        [SerializeField]
        [Range(90, 180)]
        private float maxPitch = 170f;

        /// <summary>   Keep us from going past the south pole. </summary>
        [SerializeField]
        [Range(0, 90)]
        private float minPitch = 10f;

        /// <summary>   Radius of the orbit. </summary>
        [SerializeField]
        private float radius = 4f;

        /// <summary>
        ///     We keep track of the tilt so we can make small changes to it as the actor
        ///     rotates. This is safter than trying to do a full rotation all at once which can
        ///     cause odd rotations as we hit 180 degrees.
        /// </summary>
        private Quaternion tilt = Quaternion.identity;

        /// <summary>
        ///     Represents the "pole" that the camera is attached to the anchor with. This pole is
        ///     the direction from the anchor to the camera (in natural "up" space)
        /// </summary>
        private Vector3 toCameraDirection = Vector3.back;

        /// <summary>   Late update. </summary>
        public void LateUpdate()
        {
            // Grab the rotation amount. We do the inverse tilt so we calculate the rotation in
            // "natural up" space. Later we'll use the tilt to put it back into "anchor up" space.
            Quaternion invTilt = Anchor.up.FromToRotation(Vector3.up);

            // Yaw is simple as we can go 360
            Quaternion yaw = Quaternion.AngleAxis(InputSource.GetCameraTwoAxis().x * degreesPerTick,
                invTilt * transform.up);

            // Pitch is more complicated since we can't go beyond the north/south pole
            float pitchAngle = Vector3.Angle(toCameraDirection, invTilt * Anchor.up);

            float pitchDelta = (invertPitch ? -1f : 1f) * InputSource.GetCameraTwoAxis().y;
            if (pitchAngle < minPitch && pitchDelta > 0f)
            {
                pitchDelta = 0f;
            }
            else if (pitchAngle > maxPitch && pitchDelta < 0f)
            {
                pitchDelta = 0f;
            }

            Quaternion pitch = Quaternion.AngleAxis(pitchDelta, invTilt * transform.right);

            // Calculate the new "natural up" direction
            toCameraDirection = pitch * yaw * toCameraDirection;

            // Update our tilt to match the anchor's tilt
            tilt = tilt.Up().FromToRotation(Anchor.up) * tilt;

            // Put the new direction relative to the anchor's tilt
            Vector3 tiltedTocameraDirection = tilt * toCameraDirection;
            if (tiltedTocameraDirection.IsApproximatelyVectorZero())
            {
                tiltedTocameraDirection = -Anchor.forward;
            }

            // Calculate the new orbit center (anchor) and camera position
            transform.position = OffsettedAnchorPosition + tiltedTocameraDirection.normalized * radius;
            transform.rotation =
                Quaternion.LookRotation(
                    OffsettedAnchorPosition - (OffsettedAnchorPosition + tiltedTocameraDirection.normalized * radius),
                    Anchor.up);
        }
    }
}