// file:	Assets\PaladinCharacter\Scripts\Utility\Vector3Extensions.cs
//
// summary:	Implements the vector 3 extensions class

using UnityEngine;

namespace PaladinCharacter.Utility
{
    /// <summary>   Some vector 3 extensions. </summary>
    public static class Vector3Extensions
    {
        /// <summary>
        ///     A Vector3 extension method that query if 'vector' is approximately vector
        ///     zero.
        /// </summary>
        /// <param name="vector">   The vector to act on. </param>
        /// <returns>   True if approximately vector zero, false if not. </returns>
        public static bool IsApproximatelyVectorZero(this Vector3 vector)
        {
            return Mathf.Approximately(vector.x, 0) &&
                   Mathf.Approximately(vector.y, 0) & Mathf.Approximately(vector.z, 0);
        }
    }
}