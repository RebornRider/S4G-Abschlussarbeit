using UnityEngine;

namespace PaladinCharacter
{
    public class EnemyAnimator : ActorAnimator
    {

        private HitBehaviour hitBehaviour;

        public HitBehaviour HitBehaviour
        {
            get { return hitBehaviour; }
        }

        protected override void Awake()
        {
            base.Awake();
            hitBehaviour = Animator.GetBehaviour<HitBehaviour>();
        }

        public void HitHandler()
        {
            Animator.SetTrigger(ParameterNameToHash["OnHit"]);

        }
    }
}