using UnityEngine;

namespace PaladinCharacter
{
    public class PaladinInput : InputSource
    {
        [SerializeField]
        private string horizontalAxisName = "Horizontal";
        [SerializeField]
        private string verticalAxisName = "Vertical";
        [SerializeField]
        private string jumpButtonName = "Jump";
        [SerializeField]
        private string dashButtonName = "Fire3";

        public override Vector2 GetMovementTwoAxis()
        {
            return new Vector2(Input.GetAxis(horizontalAxisName), Input.GetAxis(verticalAxisName));
        }

        public override Vector2 GetCameraTwoAxis()
        {
            return new Vector2(Input.GetAxis(horizontalAxisName), Input.GetAxis(verticalAxisName));
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