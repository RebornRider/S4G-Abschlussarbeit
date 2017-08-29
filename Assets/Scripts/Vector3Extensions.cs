using UnityEngine;

namespace PaladinCharacter
{
    public static class Vector3Extensions
    {
        public static bool IsApproximatelyVectorZero(this Vector3 vector)
        {
            return Mathf.Approximately(vector.x, 0) && Mathf.Approximately(vector.y, 0) & Mathf.Approximately(vector.z, 0);
        }
    }
}