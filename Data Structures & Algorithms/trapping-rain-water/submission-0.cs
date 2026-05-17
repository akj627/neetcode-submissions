public class Solution {
    public int Trap(int[] height) {
        var maxLeft = new int[height.Length];
        var maxRight = new int[height.Length];
        var sum = 0;

        maxLeft[0]=0;
        maxRight[height.Length - 1]=0;

        for (var i=1;i < height.Length;i++)
        {
            maxLeft[i]=Math.Max(maxLeft[i-1],height[i-1]);
        }
        for (var i=height.Length - 2;i >=0;i--)
        {
            maxRight[i]=Math.Max(maxRight[i+1],height[i+1]);
        }
        for (var i=0;i < height.Length;i++)
        {
            sum += Math.Max(0, Math.Min(maxLeft[i],maxRight[i]) - height[i]);
        }
        return sum;
    }
}
