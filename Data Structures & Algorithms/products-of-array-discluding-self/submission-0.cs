public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = new int[nums.Length];
        var prefix = 1;
        var postfix = 1;
        res[0] = 1;
        res[nums.Length - 1] = 1;

        for (var i = 1;i < nums.Length;i++)
        {
            prefix *= nums[i - 1];
            res[i] = prefix;
        }

        for (var i = nums.Length - 2;i >= 0;i--)
        {
            postfix *= nums[i + 1];
            res[i] *= postfix;
        }

        return res;
    }
}
