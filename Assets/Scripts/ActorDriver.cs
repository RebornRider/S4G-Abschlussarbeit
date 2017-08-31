﻿using UnityEngine;

namespace PaladinCharacter
{
    public interface IActorDriver
    {

    }

    public abstract class ActorDriver<TInputSource, TActorMover, TActorAnimator> : MonoBehaviour, IActorDriver
        where TInputSource : MonoBehaviour, IInputSource
        where TActorMover : MonoBehaviour, IActorMover
        where TActorAnimator : MonoBehaviour, IActorAnimator
    {
        [SerializeField]
        protected TActorAnimator Animator;
        [SerializeField]
        protected TActorMover Mover;
        [SerializeField]
        protected TInputSource InputSource;


        protected virtual void Awake()
        {
            Mover = Mover ?? GetComponent<TActorMover>();
            InputSource = InputSource ?? GetComponent<TInputSource>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }

        protected virtual void OnValidate()
        {
            Mover = Mover ?? GetComponent<TActorMover>();
            InputSource = InputSource ?? GetComponent<TInputSource>();
            Animator = Animator ?? GetComponent<TActorAnimator>();
        }
    }
}