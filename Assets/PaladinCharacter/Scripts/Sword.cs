// file:	Assets\PaladinCharacter\Scripts\Sword.cs
//
// summary:	Implements the sword class

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   A sword. </summary>
    public class Sword : Actor
    {
        /// <summary>   The already hit. </summary>
        private readonly List<EnemyDriver> alreadyHit = new List<EnemyDriver>();

        /// <summary>   The attack sound coroutine. </summary>
        private Coroutine attackSoundCoroutine;

        /// <summary>   The audio source. </summary>
        private AudioSource audioSource;

        /// <summary>   The impact sound. </summary>
        [SerializeField]
        private AudioClip impactSound;

        /// <summary>   True if this object is attacking. </summary>
        private bool isAttacking;

        /// <summary>   The maximum damage. </summary>
        [SerializeField]
        private float maxDamage = 100.0f;

        /// <summary>   The minimum damage. </summary>
        [SerializeField]
        private float minDamage = 50.0f;

        /// <summary>   The swing sound. </summary>
        [SerializeField]
        private AudioClip swingSound;

        /// <summary>   Awakes this object. </summary>
        protected void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        /// <summary>   Handler, called when the attack start. </summary>
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

        /// <summary>   Play attck sound. </summary>
        /// <returns>   An IEnumerator. </returns>
        private IEnumerator PlayAttckSound()
        {
            yield return new WaitForSeconds(0.2f);
            audioSource.Stop();
            audioSource.PlayOneShot(swingSound);
        }

        /// <summary>   Handler, called when the attack end. </summary>
        public void AttackEndHandler()
        {
            alreadyHit.Clear();
            isAttacking = false;
        }

        /// <summary>   Executes the trigger enter action. </summary>
        /// <param name="other">    The other. </param>
        private void OnTriggerEnter(Collider other)
        {
            HandleCollision(other);
        }

        /// <summary>   Executes the trigger stay action. </summary>
        /// <param name="other">    The other. </param>
        private void OnTriggerStay(Collider other)
        {
            HandleCollision(other);
        }

        /// <summary>   Handles the collision described by other. </summary>
        /// <param name="other">    The other. </param>
        private void HandleCollision(Collider other)
        {
            if (isAttacking == false)
            {
                return;
            }

            var enemy = other.gameObject.GetComponent<EnemyDriver>();
            if (enemy == null || alreadyHit.Contains(enemy))
            {
                return;
            }

            alreadyHit.Add(enemy);
            enemy.HitHandler(Random.Range(minDamage, maxDamage));
            AudioSource.PlayClipAtPoint(impactSound, transform.position);
        }
    }
}