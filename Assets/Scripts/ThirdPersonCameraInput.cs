using UnityEngine;

namespace PaladinCharacter
{
    public class ThirdPersonCameraInput : InputSource
    {
        [SerializeField]
        private string horizontalCameraAxis = "Mouse X";
        [SerializeField]
        private string verticalCameraAxis = "Mouse Y";

        public Vector2 GetCameraTwoAxis()
        {
            return new Vector2(Input.GetAxis(horizontalCameraAxis), Input.GetAxis(verticalCameraAxis));
        }
    }
}