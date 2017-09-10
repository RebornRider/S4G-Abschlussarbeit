// file:	Assets\PaladinCharacter\Scripts\DamagePopup.cs
//
// summary:	Implements the damage popup class

using UnityEngine;
using UnityEngine.UI;

namespace PaladinCharacter
{
    /// <summary>   A damage popup. </summary>
    public class DamagePopup : MonoBehaviour
    {
        /// <summary>   The animation. </summary>
        [SerializeField]
        private Animator anim;

        /// <summary>   The damage. </summary>
        private float damage;

        /// <summary>   The damage outline. </summary>
        private Outline damageOutline;

        /// <summary>   The damage text. </summary>
        private Text damageText;

        /// <summary>   True if this object is showing. </summary>
        private bool isShowing;

        /// <summary>   The life time. </summary>
        private float lifeTime = 1;

        /// <summary>   The outline color. </summary>
        private Color outlineColor = Color.clear;

        /// <summary>   Target for the. </summary>
        private Transform target;

        /// <summary>   Target offset. </summary>
        private Vector3 targetOffset;

        /// <summary>   The text color. </summary>
        private Color textColor = Color.magenta;

        /// <summary>   The time till death. </summary>
        private float timeTillDeath = 1;

        /// <summary>   Awakes this object. </summary>
        private void Awake()
        {
            damageText = GetComponentInChildren<Text>(true);
            damageOutline = GetComponentInChildren<Outline>(true);
        }

        /// <summary>   Sets a damage. </summary>
        /// <param name="damage">   The damage. </param>
        /// <returns>   A DamagePopup. </returns>
        public DamagePopup SetDamage(float damage)
        {
            this.damage = damage;

            return this;
        }

        /// <summary>   Sets text color. </summary>
        /// <param name="color">    The color. </param>
        /// <returns>   A DamagePopup. </returns>
        public DamagePopup SetTextColor(Color color)
        {
            textColor = color;

            return this;
        }

        /// <summary>   Sets outline color. </summary>
        /// <param name="color">    The color. </param>
        /// <returns>   A DamagePopup. </returns>
        public DamagePopup SetOutlineColor(Color color)
        {
            outlineColor = color;

            return this;
        }

        /// <summary>   Sets a target. </summary>
        /// <param name="target">   Target for the. </param>
        /// <returns>   A DamagePopup. </returns>
        public DamagePopup SetTarget(Transform target)
        {
            this.target = target;

            return this;
        }

        /// <summary>   Sets target offset. </summary>
        /// <param name="targetOffset"> Target offset. </param>
        /// <returns>   A DamagePopup. </returns>
        public DamagePopup SetTargetOffset(Vector3 targetOffset)
        {
            this.targetOffset = targetOffset;

            return this;
        }

        /// <summary>   Sets life time. </summary>
        /// <param name="lifeTime"> (Optional) The life time. </param>
        /// <returns>   A DamagePopup. </returns>
        public DamagePopup SetLifeTime(float lifeTime)
        {
            this.lifeTime = lifeTime;
            timeTillDeath = this.lifeTime;
            return this;
        }

        /// <summary>   Shows the given life time. </summary>
        /// <param name="lifeTime"> (Optional) The life time. </param>
        public void Show(float lifeTime = 1)
        {
            SetLifeTime(lifeTime);
            Show();
        }

        /// <summary>   Shows this object. </summary>
        public void Show()
        {
            damageText.text = Mathf.RoundToInt(damage).ToString();
            damageText.color = textColor;
            damageOutline.effectColor = outlineColor;

            isShowing = true;

            anim.SetFloat("Duration", Mathf.Approximately(lifeTime, 0) ? 0 : 1 / lifeTime);
        }

        /// <summary>   Late update. </summary>
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

            timeTillDeath -= Time.deltaTime;
            if (timeTillDeath <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}