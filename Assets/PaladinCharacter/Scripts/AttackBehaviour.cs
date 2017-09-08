using System;
using UnityEngine;

namespace PaladinCharacter
{
    public class AttackBehaviour : StateMachineBehaviour
    {
        public event Action<int> OnAttackStarted = delegate { };
        public event Action<int> OnAttackEnded = delegate { };

        private bool isAttacking;
        public bool IsAttacking { get { return isAttacking; } }



        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            isAttacking = true;
            OnAttackStarted(stateInfo.shortNameHash);
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            isAttacking = false;
            OnAttackEnded(stateInfo.shortNameHash);
        }
    }
}
