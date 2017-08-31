using UnityEngine;

namespace PaladinCharacter
{
    public class PaladinInput : InputSource
    {
        [SerializeField]
        private string horizontalMovementAxis = "Horizontal";
        [SerializeField]
        private string verticalMovementAxis = "Vertical";
        [SerializeField]
        private string horizontalCameraAxis = "Mouse X";
        [SerializeField]
        private string verticalCameraAxis = "Mouse Y";
        [SerializeField]
        private string jumpButtonName = "Jump";
        [SerializeField]
        private string dashButtonName = "Fire3";

        public override Vector2 GetMovementTwoAxis()
        {
            return new Vector2(Input.GetAxis(horizontalMovementAxis), Input.GetAxis(verticalMovementAxis));
        }

        public override Vector2 GetCameraTwoAxis()
        {
            return new Vector2(Input.GetAxis(horizontalCameraAxis), Input.GetAxis(verticalCameraAxis));
        }

        public override bool WasJumpPressed()
        {
            return Input.GetButtonDown(jumpButtonName);
        }

        public override bool WasDashPressed()
        {
            return Input.GetButtonDown(dashButtonName);
        }
    }
}