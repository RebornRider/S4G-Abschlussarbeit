// file:	Assets\PaladinCharacter\Scripts\PaladinDriver.cs
//
// summary:	Implements the paladin driver class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   A paladin driver. </summary>
    public class PaladinDriver : CharacterDriver<PaladinInput, ThirdPersonCamera, CharacterMover, PaladinAnimator>
    {
        /// <summary>   The dash distance. </summary>
        [SerializeField]
        private float dashDistance = 2.0f;

        /// <summary>   The fall speed. </summary>
        [SerializeField]
        private float fallSpeed = 50.0f;

        /// <summary>   The forward speed. </summary>
        [SerializeField]
        private float forwardSpeed = 100.0f;

        /// <summary>   Height of the jump. </summary>
        [SerializeField]
        private float jumpHeight = 10.0f;

        /// <summary>   The sideward speed. </summary>
        [SerializeField]
        private float sidewardSpeed = 100.0f;

        /// <summary>   The sword. </summary>
        [SerializeField]
        private Sword sword;


        /// <summary>   Updates this object. </summary>
        public void Update()
        {
            if (Animator.AttackBehaviour.IsAttacking == false)
            {
                if (InputSource.WasAttackPressed() && Mover.IsGrounded)
                {
                    StartAttacking();
                }

                Mover.SetIntendedVelocity(GetIntendedVelocity());


                Mover.CheckGrounding();
                if (InputSource.WasDashPressed() && Mover.IsGrounded)
                {
                    Mover.Dash(dashDistance);
                }
                if (InputSource.WasJumpPressed() && Mover.IsGrounded)
                {
                    Mover.Jump(jumpHeight);
                }
            }
            else
            {
                Mover.SetIntendedVelocity(Vector3.zero);
            }
        }

        /// <summary>   Starts an attacking. </summary>
        private void StartAttacking()
        {
            Animator.AttackHandler();
            sword.AttackStartHandler();
            Animator.AttackBehaviour.OnAttackEnded += AttackEndedHandler;
        }

        /// <summary>   Handler, called when the attack ended. </summary>
        /// <param name="stateInfoHash">    The state information hash. </param>
        private void AttackEndedHandler(int stateInfoHash)
        {
            Animator.AttackBehaviour.OnAttackEnded -= AttackEndedHandler;
            sword.AttackEndHandler();
        }

        /// <summary>   Gets intended velocity. </summary>
        /// <returns>   The intended velocity. </returns>
        private Vector3 GetIntendedVelocity()
        {
            if (Mover.IsGrounded)
            {
                Vector3 forwardMovement =
                    Vector3.ProjectOnPlane(
                        CameraRig.transform.forward * InputSource.GetMovementTwoAxis().y * forwardSpeed, Vector3.up);
                Vector3 sidewardsMovement =
                    Vector3.ProjectOnPlane(
                        CameraRig.transform.right * InputSource.GetMovementTwoAxis().x * sidewardSpeed, Vector3.up);

                Vector3 movementDirection = Vector3.Lerp(forwardMovement, sidewardsMovement, 0.5f);
                Debug.DrawRay(transform.position, movementDirection, Color.cyan);

                return movementDirection;
            }
            return Vector3.down * fallSpeed;
        }
    }
}