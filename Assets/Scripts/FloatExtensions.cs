public static class FloatExtensions
{
    // Maps a value from some arbitrary range to the 0 to 1 range
    public static float Remap01(this float value, float min, float max)
    {
        return (value - min) * 1f / (max - min);
    }

    // Maps a value from one arbitrary range to another arbitrary range
    public static float RemapRange(this float value, float leftMin, float leftMax, float rightMin, float rightMax)
    {
        return rightMin + (value - leftMin) * (rightMax - rightMin) / (leftMax - leftMin);
    }
}
