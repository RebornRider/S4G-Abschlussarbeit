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
        private string jumpButtonName = "Jump";
        [SerializeField]
        private string dashButtonName = "Fire3";
        [SerializeField]
        private string attackButtonName = "Fire1";

        public Vector2 GetMovementTwoAxis()
        {
            return new Vector2(Input.GetAxis(horizontalMovementAxis), Input.GetAxis(verticalMovementAxis));
        }

        public bool WasJumpPressed()
        {
            return Input.GetButtonDown(jumpButtonName);
        }

        public bool WasDashPressed()
        {
            return Input.GetButtonDown(dashButtonName);
        }

        public bool WasAttackhPressed()
        {
            return Input.GetButtonDown(attackButtonName);
        }
    }
}