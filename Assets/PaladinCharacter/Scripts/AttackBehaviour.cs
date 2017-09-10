// file:	Assets\PaladinCharacter\Scripts\AttackBehaviour.cs
//
// summary:	Implements the attack behaviour class

using System;
using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   An attack behaviour. </summary>
    public class AttackBehaviour : StateMachineBehaviour
    {
        /// <summary>   True if this object is attacking. </summary>
        private bool isAttacking;

        /// <summary>   Gets a value indicating whether this object is attacking. </summary>
        /// <value> True if this object is attacking, false if not. </value>
        public bool IsAttacking
        {
            get { return isAttacking; }
        }

        /// <summary>   Event queue for all listeners interested in OnAttackStarted events. </summary>
        public event Action<int> OnAttackStarted = delegate { };

        /// <summary>   Event queue for all listeners interested in OnAttackEnded events. </summary>
        public event Action<int> OnAttackEnded = delegate { };

        /// <summary>   Executes the state enter action. </summary>
        /// <param name="animator">     The animator. </param>
        /// <param name="stateInfo">    Information describing the state. </param>
        /// <param name="layerIndex">   Zero-based index of the layer. </param>
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            isAttacking = true;
            OnAttackStarted(stateInfo.shortNameHash);
        }

        /// <summary>   Executes the state exit action. </summary>
        /// <param name="animator">     The animator. </param>
        /// <param name="stateInfo">    Information describing the state. </param>
        /// <param name="layerIndex">   Zero-based index of the layer. </param>
        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            isAttacking = false;
            OnAttackEnded(stateInfo.shortNameHash);
        }
    }
}