public class Solution {
    public int MissingNumber(int[] nums) {
        var xored = nums.Length;

        for (var i=0;i<nums.Length;i++)
        {
            xored = xored ^ i ^ nums[i];
        }

        return xored;

/*        var sum1 = 0;
        var sum2 = nums.Length;
        for (var i=0;i<nums.Length;i++)
        {
            sum1 += nums[i];
            sum2 += i;
        }

        return sum2 - sum1;*/
    }
}