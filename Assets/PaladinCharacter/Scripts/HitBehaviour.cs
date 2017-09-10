// file:	Assets\PaladinCharacter\Scripts\HitBehaviour.cs
//
// summary:	Implements the hit behaviour class

using System;
using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   A hit behaviour. </summary>
    public class HitBehaviour : StateMachineBehaviour
    {
        /// <summary>   Gets a value indicating whether this object is hit. </summary>
        /// <value> True if this object is hit, false if not. </value>
        public bool IsHit { get; private set; }

        /// <summary>   Event queue for all listeners interested in OnHitStarted events. </summary>
        public event Action<int> OnHitStarted = delegate { };

        /// <summary>   Event queue for all listeners interested in OnHitEnded events. </summary>
        public event Action<int> OnHitEnded = delegate { };

        /// <summary>   Executes the state enter action. </summary>
        /// <param name="animator">     The animator. </param>
        /// <param name="stateInfo">    Information describing the state. </param>
        /// <param name="layerIndex">   Zero-based index of the layer. </param>
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            IsHit = true;
            OnHitStarted(stateInfo.shortNameHash);
        }

        /// <summary>   Executes the state exit action. </summary>
        /// <param name="animator">     The animator. </param>
        /// <param name="stateInfo">    Information describing the state. </param>
        /// <param name="layerIndex">   Zero-based index of the layer. </param>
        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            IsHit = false;
            OnHitEnded(stateInfo.shortNameHash);
        }
    }
}