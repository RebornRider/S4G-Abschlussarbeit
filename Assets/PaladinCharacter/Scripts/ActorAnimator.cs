// file:	Assets\PaladinCharacter\Scripts\ActorAnimator.cs
//
// summary:	Implements the actor animator class

using System.Collections.Generic;
using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   Interface for actor animators. </summary>
    public interface IActorAnimator
    {
    }

    /// <summary>   An actor animator. </summary>
    public abstract class ActorAnimator : MonoBehaviour, IActorAnimator
    {
        /// <summary>   Maps a parameter name to its corresponding hash. </summary>
        protected readonly Dictionary<string, int> ParameterNameToHash = new Dictionary<string, int>();

        /// <summary>   The Unity animator. </summary>
        [SerializeField]
        protected Animator Animator;

        /// <summary>   Awakes this object. </summary>
        protected virtual void Awake()
        {
            Animator = Animator ?? GetComponent<Animator>();
            PopulateParameterHashCache();
        }

        /// <summary>   Populate parameter hash cache. </summary>
        private void PopulateParameterHashCache()
        {
            ParameterNameToHash.Clear();

            if (Animator.runtimeAnimatorController == null)
            {
                return;
            }

            for (var i = 0; i < Animator.parameters.Length; i++)
                ParameterNameToHash.Add(Animator.GetParameter(i).name, Animator.GetParameter(i).nameHash);
        }

        /// <summary>   Executes the validate action. </summary>
        protected virtual void OnValidate()
        {
            Animator = Animator ?? GetComponent<Animator>();
        }
    }
}