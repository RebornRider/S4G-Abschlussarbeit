using UnityEngine;

namespace PaladinCharacter
{
    public class LockRoation : MonoBehaviour
    {
        private Quaternion rotation;
        private void Awake()
        {
            rotation = transform.rotation;
        }

        private void Update()
        {
            transform.rotation = rotation;
        }

        private void FixedUpdate()
        {
            transform.rotation = rotation;
        }

        private void LateUpdate()
        {
            transform.rotation = rotation;
        }
    }
}
