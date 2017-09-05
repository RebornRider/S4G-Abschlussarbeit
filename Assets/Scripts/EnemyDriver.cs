using UnityEngine;

namespace PaladinCharacter
{
    public class EnemyDriver : PawnDriver<InputSourceStub, ActorMoverStub, EnemyAnimator>
    {
        [SerializeField]
        private float fallSpeed = 50.0f;
        [SerializeField]
        private GameObject damagePopupPrefab;
        [SerializeField]
        private Vector3 damagePopUpPivot = new Vector3(0, 1.8f, 0);
        [SerializeField]
        private float minDamagePopupRandomOffset = 0.3f;
        [SerializeField]
        private float maxDamagePopupRandomOffset = 0.6f;
        [SerializeField]
        private Color minDamageColor = Color.green;
        [SerializeField]
        private Color maxDamageColor = Color.red;
        [SerializeField]
        private float minDamage = 50;
        [SerializeField]
        private float maxDamage = 100;

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

        protected Vector3 GetIntendedVelocity()
        {
            Mover.CheckGrounding();
            if (Mover.IsGrounded)
            {
                return Vector3.zero;
            }
            else
            {
                return Vector3.down * fallSpeed;
            }
        }

        public void HitHandler(float damage = 0)
        {
            Animator.HitHandler();
            if (damagePopupPrefab)
            {
                DamagePopup damagePopup = Instantiate(damagePopupPrefab, transform.position, Quaternion.identity).GetComponent<DamagePopup>();

                Vector3 randOffset = CalculateRandomUpwardsDirectionOnUnitSphere() * Random.Range(minDamagePopupRandomOffset, maxDamagePopupRandomOffset);

                damagePopup.SetDamage(damage)
                    .SetTarget(transform)
                    .SetTargetOffset(damagePopUpPivot + randOffset)
                    .SetTextColor(Color.Lerp(minDamageColor, maxDamageColor, damage.Remap01(minDamage, maxDamage)))
                    .SetOutlineColor(new Color(1, 1, 1, 0.5f))
                    .SetLifeTime(0.75f)
                    .Show();
            }

        }

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