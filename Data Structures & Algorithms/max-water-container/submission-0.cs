public class Solution {
    public int MaxArea(int[] heights) {
        var l = 0;
        var r = heights.Length - 1;
        var max = 0;

        while (l < r)
        {
            max = Math.Max(max, Math.Min(heights[l], heights[r]) * (r - l));
            if (heights[l] <= heights[r])
                l++;
            else
                r--;
        }
        return max;
    }
}
