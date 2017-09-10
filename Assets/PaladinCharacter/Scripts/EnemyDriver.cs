// file:	Assets\PaladinCharacter\Scripts\EnemyDriver.cs
//
// summary:	Implements the enemy driver class

using PaladinCharacter.Utility;
using UnityEngine;

namespace PaladinCharacter
{
    /// <summary>   An enemy driver. </summary>
    public class EnemyDriver : PawnDriver<InputSourceStub, ActorMoverStub, EnemyAnimator>
    {
        /// <summary>   The damage pop up pivot. </summary>
        [SerializeField]
        private Vector3 damagePopUpPivot = new Vector3(0, 1.8f, 0);

        /// <summary>   The damage popup prefab. </summary>
        [SerializeField]
        private GameObject damagePopupPrefab;

        /// <summary>   The fall speed. </summary>
        [SerializeField]
        private float fallSpeed = 50.0f;

        /// <summary>   The maximum damage. </summary>
        [SerializeField]
        private float maxDamage = 100;

        /// <summary>   The maximum damage color. </summary>
        [SerializeField]
        private Color maxDamageColor = Color.red;

        /// <summary>   The maximum damage popup random offset. </summary>
        [SerializeField]
        private float maxDamagePopupRandomOffset = 0.6f;

        /// <summary>   The minimum damage. </summary>
        [SerializeField]
        private float minDamage = 50;

        /// <summary>   The minimum damage color. </summary>
        [SerializeField]
        private Color minDamageColor = Color.green;

        /// <summary>   The minimum damage popup random offset. </summary>
        [SerializeField]
        private float minDamagePopupRandomOffset = 0.3f;

        /// <summary>   Updates this object. </summary>
        public void Update()
        {
            if (Animator.HitBehaviour.IsHit == false)
            {
                Mover.SetIntendedVelocity(Vector3.zero);
            }
            else
            {
                Mover.SetIntendedVelocity(GetIntendedVelocity());
            }
        }

        /// <summary>   Gets intended velocity. </summary>
        /// <returns>   The intended velocity. </returns>
        protected Vector3 GetIntendedVelocity()
        {
            Mover.CheckGrounding();
            if (Mover.IsGrounded)
            {
                return Vector3.zero;
            }
            return Vector3.down * fallSpeed;
        }

        /// <summary>   Handler, called when the hit. </summary>
        /// <param name="damage">   (Optional) The damage. </param>
        public void HitHandler(float damage = 0)
        {
            Animator.HitHandler();
            if (damagePopupPrefab)
            {
                var damagePopup = Instantiate(damagePopupPrefab, transform.position, Quaternion.identity)
                    .GetComponent<DamagePopup>();

                Vector3 randOffset = CalculateRandomUpwardsDirectionOnUnitSphere() *
                                     Random.Range(minDamagePopupRandomOffset, maxDamagePopupRandomOffset);

                damagePopup.SetDamage(damage)
                    .SetTarget(transform)
                    .SetTargetOffset(damagePopUpPivot + randOffset)
                    .SetTextColor(Color.Lerp(minDamageColor, maxDamageColor, damage.Remap01(minDamage, maxDamage)))
                    .SetOutlineColor(new Color(1, 1, 1, 0.5f))
                    .SetLifeTime(0.75f)
                    .Show();
            }
        }

        /// <summary>   Calculates the random upwards direction unit sphere. </summary>
        /// <returns>   The calculated random upwards direction unit sphere. </returns>
        private Vector3 CalculateRandomUpwardsDirectionOnUnitSphere()
        {
            Vector3 randOffset = Random.onUnitSphere;
            if (Vector3.Dot(randOffset, transform.up) < 0)
            {
                randOffset *= -1;
            }

            return randOffset;
        }
    }
}