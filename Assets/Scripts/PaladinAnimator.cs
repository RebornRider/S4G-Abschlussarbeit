using UnityEngine;

namespace PaladinCharacter
{
    public class PaladinAnimator : ActorAnimator
    {
        [SerializeField]
        protected AnimationCurve distanceToForwardMovementSpeed;
        [SerializeField]
        protected int AttackAnimCount;

        public void SetMovementDistance(float distance)
        {
            Animator.SetFloat(parameterNameToHash["ForwardMovementSpeed"],
                distanceToForwardMovementSpeed.Evaluate(distance));
        }

        public void Attack()
        {
            Animator.SetTrigger(parameterNameToHash["OnAttack"]);
            Animator.SetFloat(parameterNameToHash["AttackIndex"],
                Random.Range(0, 4));
        }
    }
}
