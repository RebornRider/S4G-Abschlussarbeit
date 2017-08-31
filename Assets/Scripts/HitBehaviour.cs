using System;
using UnityEngine;

namespace PaladinCharacter
{
    public class HitBehaviour : StateMachineBehaviour
    {
        public event Action<int> OnHitStarted = delegate { };
        public event Action<int> OnHitEnded = delegate { };

        private bool isHit;
        public bool IsHit { get { return isHit; } }



        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            isHit = true;
            OnHitStarted(stateInfo.shortNameHash);
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            isHit = false;
            OnHitEnded(stateInfo.shortNameHash);
        }
    }
}