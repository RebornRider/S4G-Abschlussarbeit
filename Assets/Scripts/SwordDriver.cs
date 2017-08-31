using System.Collections.Generic;
using UnityEngine;

namespace PaladinCharacter
{
    public class SwordDriver : ActorDriver<InputSourceStub, ActorMoverStub, ActorAnimatorStub>
    {
        [SerializeField]
        private float minDamage = 50.0f;
        [SerializeField]
        private float maxDamage = 100.0f;

        private readonly List<EnemyDriver> alreadyHit = new List<EnemyDriver>();

        private bool isAttcking;

        public void AttackStartHandler()
        {
            alreadyHit.Clear();
            isAttcking = true;
        }

        public void AttackEndHandler()
        {
            alreadyHit.Clear();
            isAttcking = false;
        }

        private void OnTriggerEnter(Collider other)
        {
            HandleCollision(other);
        }

        private void OnTriggerStay(Collider other)
        {
            HandleCollision(other);
        }

        private void HandleCollision(Collider other)
        {
            if (isAttcking == false)
            {
                return;
            }

            var enemy = other.gameObject.GetComponent<EnemyDriver>();

            if (enemy != null && alreadyHit.Contains(enemy) == false)
            {
                alreadyHit.Add(enemy);
                enemy.HitHandler(Random.Range(minDamage, maxDamage));
            }
        }
    }
}