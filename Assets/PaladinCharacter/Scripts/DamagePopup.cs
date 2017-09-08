using UnityEngine;
using UnityEngine.UI;

namespace PaladinCharacter
{

    public class DamagePopup : MonoBehaviour
    {
        [SerializeField]
        private Animator anim;

        private float damage;
        private Color textColor = Color.magenta;
        private Color outlineColor = Color.clear;
        private Text damageText;
        private Outline damageOutline;
        private Transform target;
        private Vector3 targetOffset;
        private float lifeTime = 1;
        private float timeTilDeath = 1;
        private bool isShowing;

        private void Awake()
        {
            damageText = GetComponentInChildren<Text>(includeInactive: true);
            damageOutline = GetComponentInChildren<Outline>(includeInactive: true);
        }

        public DamagePopup SetDamage(float damage)
        {
            this.damage = damage;

            return this;
        }

        public DamagePopup SetTextColor(Color color)
        {
            textColor = color;

            return this;
        }

        public DamagePopup SetOutlineColor(Color color)
        {
            outlineColor = color;

            return this;
        }

        public DamagePopup SetTarget(Transform target)
        {
            this.target = target;

            return this;
        }

        public DamagePopup SetTargetOffset(Vector3 targetOffset)
        {
            this.targetOffset = targetOffset;

            return this;
        }

        public DamagePopup SetLifeTime(float lifeTime)
        {
            this.lifeTime = lifeTime;
            this.timeTilDeath = this.lifeTime;
            return this;
        }


        public void Show(float lifeTime = 1)
        {
            SetLifeTime(lifeTime);
            Show();
        }

        public void Show()
        {
            damageText.text = Mathf.RoundToInt(damage).ToString();
            damageText.color = textColor;
            damageOutline.effectColor = outlineColor;

            isShowing = true;

            anim.SetFloat("Duration", Mathf.Approximately(lifeTime, 0) ? 0 : 1 / lifeTime);
        }

        private void LateUpdate()
        {
            if (isShowing == false)
            {
                return;
            }

            if (target)
            {
                transform.position = target.position + target.worldToLocalMatrix.MultiplyVector(targetOffset);
            }

            transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward,
                Camera.main.transform.rotation * Vector3.up);

            timeTilDeath -= Time.deltaTime;
            if (timeTilDeath <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}