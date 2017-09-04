using System.Collections;
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
        [SerializeField]
        private AudioClip impactSound;
        [SerializeField]
        private AudioClip swingSound;

        private readonly List<EnemyDriver> alreadyHit = new List<EnemyDriver>();

        private AudioSource audioSource;
        private bool isAttacking;

        protected override void Awake()
        {
            base.Awake();
            audioSource = GetComponent<AudioSource>();
        }

        private Coroutine attackSoundCoroutine;
        public void AttackStartHandler()
        {
            alreadyHit.Clear();
            isAttacking = true;

            if (attackSoundCoroutine != null)
            {
                StopCoroutine(attackSoundCoroutine);
            }

            attackSoundCoroutine = StartCoroutine(PlayAttckSound());
        }

        private IEnumerator PlayAttckSound()
        {
            yield return new WaitForSeconds(0.2f);
            audioSource.PlayOneShot(swingSound);
        }

        public void AttackEndHandler()
        {
            alreadyHit.Clear();
            isAttacking = false;
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
            if (isAttacking == false)
            {
                return;
            }

            var enemy = other.gameObject.GetComponent<EnemyDriver>();

            if (enemy != null && alreadyHit.Contains(enemy) == false)
            {
                alreadyHit.Add(enemy);
                enemy.HitHandler(Random.Range(minDamage, maxDamage));
                AudioSource.PlayClipAtPoint(impactSound, transform.position);
            }
        }
    }
}