// file:	Assets\PaladinCharacter\Scripts\ThirdPersonCameraInput.cs
//
// summary:	Implements the third person camera input class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   A third person camera input. </summary>
    public class ThirdPersonCameraInput : InputSource
    {
        /// <summary>   The horizontal camera axis. </summary>
        [SerializeField]
        private string horizontalCameraAxis = "Mouse X";

        /// <summary>   The vertical camera axis. </summary>
        [SerializeField]
        private string verticalCameraAxis = "Mouse Y";

        /// <summary>   Gets camera two axis. </summary>
        /// <returns>   The camera two axis. </returns>
        public Vector2 GetCameraTwoAxis()
        {
            return new Vector2(Input.GetAxis(horizontalCameraAxis), Input.GetAxis(verticalCameraAxis));
        }
    }
}