// file:	Assets\PaladinCharacter\Scripts\Utility\FloatExtensions.cs
//
// summary:	Implements the float extensions class

namespace PaladinCharacter.Utility
{
    /// <summary>   Some float extensions. </summary>
    public static class FloatExtensions
    {
        /// <summary>   Maps a value from some arbitrary range to the 0 to 1 range. </summary>
        /// <param name="value">    The value to act on. </param>
        /// <param name="min">      The minimum. </param>
        /// <param name="max">      The maximum. </param>
        /// <returns>   A float. </returns>
        public static float Remap01(this float value, float min, float max)
        {
            return (value - min) * 1f / (max - min);
        }

        /// <summary>   Maps a value from one arbitrary range to another arbitrary range. </summary>
        /// <param name="value">    The value to act on. </param>
        /// <param name="oldMin">   The left minimum. </param>
        /// <param name="oldMax">   The left maximum. </param>
        /// <param name="newMin">   The right minimum. </param>
        /// <param name="newMax">   The right maximum. </param>
        /// <returns>   A float. </returns>
        public static float RemapRange(this float value, float oldMin, float oldMax, float newMin, float newMax)
        {
            return newMin + (value - oldMin) * (newMax - newMin) / (oldMax - oldMin);
        }
    }
}