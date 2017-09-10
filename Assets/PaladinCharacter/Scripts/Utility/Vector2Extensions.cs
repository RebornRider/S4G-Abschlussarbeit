// file:	Assets\PaladinCharacter\Scripts\Utility\Vector2Extensions.cs
//
// summary:	Implements the vector 2 extensions class

using UnityEngine;

namespace PaladinCharacter.Utility
{
    /// <summary>   Some vector 2 extensions. </summary>
    public static class Vector2Extensions
    {
        /// <summary>
        ///     A Vector2 extension method that query if 'vector' is approximately vector
        ///     zero.
        /// </summary>
        /// <param name="vector">   The vector to act on. </param>
        /// <returns>   True if approximately vector zero, false if not. </returns>
        public static bool IsApproximatelyVectorZero(this Vector2 vector)
        {
            return Mathf.Approximately(vector.x, 0) && Mathf.Approximately(vector.y, 0);
        }
    }
}