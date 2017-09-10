// file:	Assets\PaladinCharacter\Scripts\EnemyAnimator.cs
//
// summary:	Implements the enemy animator class

namespace PaladinCharacter
{
    /// <summary>   An enemy animator. </summary>
    public class EnemyAnimator : ActorAnimator
    {
        /// <summary>   Gets the hit behaviour. </summary>
        /// <value> The hit behaviour. </value>
        public HitBehaviour HitBehaviour { get; private set; }

        /// <summary>   Awakes this object. </summary>
        protected override void Awake()
        {
            base.Awake();
            HitBehaviour = Animator.GetBehaviour<HitBehaviour>();
        }

        /// <summary>   Handler, called when the hit. </summary>
        public void HitHandler()
        {
            Animator.SetTrigger(ParameterNameToHash["OnHit"]);
        }
    }
}