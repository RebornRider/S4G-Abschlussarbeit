﻿using UnityEngine;

namespace PaladinCharacter
{
    public class PaladinDriver : CharacterDriver<PaladinInput, ThirdPersonCamera, CharacterMover, PaladinAnimator>
    {
        [SerializeField]
        private float forwardSpeed = 100.0f;
        [SerializeField]
        private float sidewardSpeed = 100.0f;
        [SerializeField]
        private float jumpHeight = 10.0f;
        [SerializeField]
        private float dashDistance = 2.0f;
        [SerializeField]
        private float fallSpeed = 50.0f;
        [SerializeField]
        private Sword sword;


        public void Update()
        {
            if (Animator.AttackBehaviour.IsAttacking == false)
            {
                if (InputSource.WasAttackhPressed() && Mover.IsGrounded)
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

        private void StartAttacking()
        {
            Animator.AttackHandler();
            sword.AttackStartHandler();
            Animator.AttackBehaviour.OnAttackEnded += AttackEndedHandler;
        }

        private void AttackEndedHandler(int stateInfoHash)
        {
            Animator.AttackBehaviour.OnAttackEnded -= AttackEndedHandler;
            sword.AttackEndHandler();
        }

        private Vector3 GetIntendedVelocity()
        {
            if (Mover.IsGrounded)
            {
                var forwardMovement = Vector3.ProjectOnPlane(CameraRig.transform.forward * InputSource.GetMovementTwoAxis().y * forwardSpeed, Vector3.up);
                var sidewardsMovement = Vector3.ProjectOnPlane(CameraRig.transform.right * InputSource.GetMovementTwoAxis().x * sidewardSpeed, Vector3.up);

                Vector3 movementDirection = Vector3.Lerp(forwardMovement, sidewardsMovement, 0.5f);
                Debug.DrawRay(transform.position, movementDirection, Color.cyan);

                return movementDirection;
            }
            else
            {
                return Vector3.down * fallSpeed;
            }
        }
    }
}