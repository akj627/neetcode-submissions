public class Solution {
    public int MissingNumber(int[] nums) {
        // xor of a number to itself is 0
        //0 ^ 1 ^ 2 ^ 0 ^ 2 will be 1
        var xored = nums.Length;

        for (var i=0;i<nums.Length;i++)
        {
            xored = xored ^ i ^ nums[i];
        }

        return xored;

/*      
        number = difference of the 0..n range and the nums array
        var sum1 = 0;
        var sum2 = nums.Length;
        for (var i=0;i<nums.Length;i++)
        {
            sum1 += nums[i];
            sum2 += i;
        }

        return sum2 - sum1;*/
    }
}