// file:	Assets\PaladinCharacter\Scripts\PaladinAnimator.cs
//
// summary:	Implements the paladin animator class

using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   A paladin animator. </summary>
    public class PaladinAnimator : ActorAnimator
    {
        /// <summary>   Number of attack animations. </summary>
        [SerializeField]
        protected int AttackAnimCount = 2;

        /// <summary>   The attack behaviour. </summary>
        private AttackBehaviour attackBehaviour;

        /// <summary>   The distance to forward movement speed. </summary>
        [SerializeField]
        protected AnimationCurve distanceToForwardMovementSpeed;

        /// <summary>   The not grounded counter. </summary>
        private int notGroundedCounter;

        /// <summary>   Gets the attack behaviour. </summary>
        /// <value> The attack behaviour. </value>
        public AttackBehaviour AttackBehaviour
        {
            get { return attackBehaviour; }
        }

        /// <summary>   Awakes this object. </summary>
        protected override void Awake()
        {
            base.Awake();
            attackBehaviour = Animator.GetBehaviour<AttackBehaviour>();
        }

        /// <summary>   Sets movement distance. </summary>
        /// <param name="distance"> The distance. </param>
        public void SetMovementDistance(float distance)
        {
            Animator.SetFloat(ParameterNameToHash["ForwardMovementSpeed"],
                distanceToForwardMovementSpeed.Evaluate(distance));
        }

        /// <summary>   Handler, called when the jump. </summary>
        public void JumpHandler()
        {
            Animator.SetTrigger(ParameterNameToHash["OnJump"]);
        }

        /// <summary>   Sets a grounding. </summary>
        /// <param name="isGrounded">   True if this object is grounded. </param>
        public void SetGrounding(bool isGrounded)
        {
            Animator.SetBool(ParameterNameToHash["IsGrounded"], isGrounded);

            if (isGrounded)
            {
                notGroundedCounter = 0;
            }
            else
            {
                notGroundedCounter++;
            }

            if (notGroundedCounter > 5)
            {
                notGroundedCounter = 0;
                Animator.SetTrigger(ParameterNameToHash["OnFalling"]);
            }
        }


        /// <summary>   Handler, called when the attack. </summary>
        public void AttackHandler()
        {
            Animator.SetTrigger(ParameterNameToHash["OnAttack"]);
            Animator.SetFloat(ParameterNameToHash["AttackIndex"],
                Random.Range(0, AttackAnimCount));
        }
    }
}