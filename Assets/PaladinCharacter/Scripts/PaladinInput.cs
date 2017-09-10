// file:	Assets\PaladinCharacter\Scripts\PaladinInput.cs
//
// summary:	Implements the paladin input class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   A paladin input. </summary>
    public class PaladinInput : InputSource
    {
        /// <summary>   Name of the attack button. </summary>
        [SerializeField]
        private string attackButtonName = "Fire1";

        /// <summary>   Name of the dash button. </summary>
        [SerializeField]
        private string dashButtonName = "Fire3";

        /// <summary>   The horizontal movement axis. </summary>
        [SerializeField]
        private string horizontalMovementAxis = "Horizontal";

        /// <summary>   Name of the jump button. </summary>
        [SerializeField]
        private string jumpButtonName = "Jump";

        /// <summary>   The vertical movement axis. </summary>
        [SerializeField]
        private string verticalMovementAxis = "Vertical";

        /// <summary>   Gets movement two axis. </summary>
        /// <returns>   The movement two axis. </returns>
        public Vector2 GetMovementTwoAxis()
        {
            return new Vector2(Input.GetAxis(horizontalMovementAxis), Input.GetAxis(verticalMovementAxis));
        }

        /// <summary>   Determines if we can was jump pressed. </summary>
        /// <returns>   True if it succeeds, false if it fails. </returns>
        public bool WasJumpPressed()
        {
            return Input.GetButtonDown(jumpButtonName);
        }

        /// <summary>   Determines if we can was dash pressed. </summary>
        /// <returns>   True if it succeeds, false if it fails. </returns>
        public bool WasDashPressed()
        {
            return Input.GetButtonDown(dashButtonName);
        }

        /// <summary>   Determines if we can was attack pressed. </summary>
        /// <returns>   True if it succeeds, false if it fails. </returns>
        public bool WasAttackPressed()
        {
            return Input.GetButtonDown(attackButtonName);
        }
    }
}