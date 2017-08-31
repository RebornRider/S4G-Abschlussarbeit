using System.Collections.Generic;
using UnityEngine;

namespace PaladinCharacter
{
    public interface IActorAnimator
    {

    }

    public abstract class ActorAnimator : MonoBehaviour, IActorAnimator
    {
        [SerializeField]
        protected Animator Animator;
        protected readonly Dictionary<string, int> ParameterNameToHash = new Dictionary<string, int>();

        protected virtual void Awake()
        {
            Animator = Animator ?? GetComponent<Animator>();
            PopulateParameterHashCache();
        }

        private void PopulateParameterHashCache()
        {
            ParameterNameToHash.Clear();
            for (var i = 0; i < Animator.parameters.Length; i++)
            {
                ParameterNameToHash.Add(Animator.GetParameter(i).name, Animator.GetParameter(i).nameHash);
            }
        }

        protected virtual void OnValidate()
        {
            Animator = Animator ?? GetComponent<Animator>();
        }
    }

    public class ActorAnimatorStub : ActorAnimator
    {

    }
}