// file:	Assets\PaladinCharacter\Scripts\Utility\QuaternionExtensions.cs
//
// summary:	Implements the quaternion extensions class

using UnityEngine;

namespace PaladinCharacter.Utility
{
    /// <summary>   A quaternion extensions. </summary>
    public static class QuaternionExtensions
    {
        /// <summary>   Returns a vector representing this quaternion's forward direction. </summary>
        /// <param name="value">    The Quaternion to act on. </param>
        /// <returns>   A Vector3. </returns>
        public static Vector3 Forward(this Quaternion value)
        {
            return new Vector3(2 * (value.x * value.z + value.w * value.y),
                2 * (value.y * value.z - value.w * value.x),
                1 - 2 * (value.x * value.x + value.y * value.y));
        }

        /// <summary>   Returns a vector representing this quaternion's up direction. </summary>
        /// <param name="value">    The Quaternion to act on. </param>
        /// <returns>   A Vector3. </returns>
        public static Vector3 Up(this Quaternion value)
        {
            return new Vector3(2 * (value.x * value.y - value.w * value.z),
                1 - 2 * (value.x * value.x + value.z * value.z),
                2 * (value.y * value.z + value.w * value.x));
        }

        /// <summary>   Returns a vector representing this quaternion's right direction. </summary>
        /// <param name="value">    The Quaternion to act on. </param>
        /// <returns>   A Vector3. </returns>
        public static Vector3 Right(this Quaternion value)
        {
            return new Vector3(1 - 2 * (value.y * value.y + value.z * value.z),
                2 * (value.x * value.y + value.w * value.z),
                2 * (value.x * value.z - value.w * value.y));
        }

        /// <summary>   Handles smaller values better than Unity's version. </summary>
        /// <param name="u">    The from rotation. </param>
        /// <param name="v">    The to rotation. </param>
        /// <returns>   A Quaternion. </returns>
        public static Quaternion FromToRotation(this Vector3 u, Vector3 v)
        {
            float theta = Vector3.Dot(u.normalized, v.normalized);

            if (theta >= 1f)
            {
                return Quaternion.identity;
            }
            if (theta <= -1f)
            {
                Vector3 simpleAxis = Vector3.Cross(u, Vector3.right);
                if (simpleAxis.IsApproximatelyVectorZero())
                {
                    simpleAxis = Vector3.Cross(u, Vector3.up);
                }

                return Quaternion.AngleAxis(180f, simpleAxis);
            }

            float radians = Mathf.Acos(theta);
            Vector3 axis = Vector3.Cross(u, v).normalized;

            return Quaternion.AngleAxis(radians * Mathf.Rad2Deg, axis);
        }
    }
}