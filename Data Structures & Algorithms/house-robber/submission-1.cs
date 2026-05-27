public class Solution {
    public int Rob(int[] nums) {
        var rob1 = 0;
        var rob2 = 0;

        /*
        foreach (var num in nums)
        {
            var temp = Math.Max(num + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
        }

        return rob2;*/
        return robInner(rob1, rob2, 0, nums);
    }

    private int robInner(int rob1, int rob2, int num, int[] nums)
    {   
        if (num == nums.Length)
            return rob2;
        var temp = Math.Max(nums[num] + rob1, rob2);
        return robInner(rob2, temp, num + 1, nums);
    }
}
