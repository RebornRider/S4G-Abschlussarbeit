using UnityEngine;

namespace PaladinCharacter.Utility
{
    public static class Vector2Extensions
    {
        public static bool IsApproximatelyVectorZero(this Vector2 vector)
        {
            return Mathf.Approximately(vector.x, 0) && Mathf.Approximately(vector.y, 0);
        }
    }
}