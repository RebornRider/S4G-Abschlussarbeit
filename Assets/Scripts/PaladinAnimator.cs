using UnityEngine;

namespace PaladinCharacter
{
    public class PaladinAnimator : ActorAnimator
    {
        [SerializeField]
        protected AnimationCurve distanceToForwardMovementSpeed;

        public void SetMovementDistance(float distance)
        {
            Animator.SetFloat(parameterNameToHash["ForwardMovementSpeed"],
                distanceToForwardMovementSpeed.Evaluate(distance));
        }
    }
}
