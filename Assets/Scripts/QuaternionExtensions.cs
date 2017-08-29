using UnityEngine;

namespace PaladinCharacter
{
    public static class QuaternionExtensions
    {
        /// <summary>
        /// Returns a vector representing this quaternion's forward direction
        /// </summary>
        /// <param name="rThis"></param>
        /// <returns></returns>
        public static Vector3 Forward(this Quaternion rThis)
        {
            return new Vector3(2 * (rThis.x * rThis.z + rThis.w * rThis.y),
                2 * (rThis.y * rThis.z - rThis.w * rThis.x),
                1 - 2 * (rThis.x * rThis.x + rThis.y * rThis.y));
        }

        /// <summary>
        /// Returns a vector representing this quaternion's up direction
        /// </summary>
        /// <param name="rThis"></param>
        /// <returns></returns>
        public static Vector3 Up(this Quaternion rThis)
        {
            return new Vector3(2 * (rThis.x * rThis.y - rThis.w * rThis.z),
                1 - 2 * (rThis.x * rThis.x + rThis.z * rThis.z),
                2 * (rThis.y * rThis.z + rThis.w * rThis.x));
        }

        /// <summary>
        /// Returns a vector representing this quaternion's right direction
        /// </summary>
        /// <param name="rThis"></param>
        /// <returns></returns>
        public static Vector3 Right(this Quaternion rThis)
        {
            return new Vector3(1 - 2 * (rThis.y * rThis.y + rThis.z * rThis.z),
                2 * (rThis.x * rThis.y + rThis.w * rThis.z),
                2 * (rThis.x * rThis.z - rThis.w * rThis.y));
        }

        /// <summary>
        /// Handles smaller values better than Unity's version.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Quaternion FromToRotation(Vector3 u, Vector3 v)
        {
            float lTheta = Vector3.Dot(u.normalized, v.normalized);

            if (lTheta >= 1f)
            {
                return Quaternion.identity;
            }
            else if (lTheta <= -1f)
            {
                Vector3 lSimpleAxis = Vector3.Cross(u, Vector3.right);
                if (lSimpleAxis.IsApproximatelyVectorZero())
                {
                    lSimpleAxis = Vector3.Cross(u, Vector3.up);
                }

                return Quaternion.AngleAxis(180f, lSimpleAxis);
            }

            float lRadians = Mathf.Acos(lTheta);
            Vector3 lAxis = Vector3.Cross(u, v).normalized;

            return Quaternion.AngleAxis(lRadians * Mathf.Rad2Deg, lAxis);
        }
    }
}