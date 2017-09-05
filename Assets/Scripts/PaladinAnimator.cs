using UnityEngine;
using Random = UnityEngine.Random;

namespace PaladinCharacter
{
    public class PaladinAnimator : ActorAnimator
    {
        [SerializeField]
        protected AnimationCurve distanceToForwardMovementSpeed;
        [SerializeField]
        protected int AttackAnimCount = 2;

        private AttackBehaviour attackBehaviour;

        public AttackBehaviour AttackBehaviour
        {
            get { return attackBehaviour; }
        }

        protected override void Awake()
        {
            base.Awake();
            attackBehaviour = Animator.GetBehaviour<AttackBehaviour>();
        }

        public void SetMovementDistance(float distance)
        {
            Animator.SetFloat(ParameterNameToHash["ForwardMovementSpeed"],
                distanceToForwardMovementSpeed.Evaluate(distance));
        }

        public void JumpHandler()
        {
            Animator.SetTrigger(ParameterNameToHash["OnJump"]);
        }

        public void SetGrounding(bool isGrounded)
        {
            Animator.SetBool(ParameterNameToHash["isGrounded"], isGrounded);
        }


        public void AttackHandler()
        {
            Animator.SetTrigger(ParameterNameToHash["OnAttack"]);
            Animator.SetFloat(ParameterNameToHash["AttackIndex"],
                Random.Range(0, AttackAnimCount));
        }
    }
}
