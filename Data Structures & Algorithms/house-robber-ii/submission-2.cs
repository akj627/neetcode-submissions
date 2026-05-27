public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0)
            return 0;

        if (nums.Length == 1)
            return nums[0];

        return Math.Max(robIterative(0, nums), robIterative(1, nums));
        //return robInner(rob1, rob2, 0, nums);
    }

    private int robIterative (int offset, int[] nums)
    {
        var rob1 = 0;
        var rob2 = 0;

        for (var i=0;i < nums.Length - 1;i++)
        {
            var temp = Math.Max(nums[i + offset] + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
        }

        return rob2;
    }
    /*private int robInner(int rob1, int rob2, int num, int[] nums)
    {   
        if (num == nums.Length)
            return rob2;
        var temp = Math.Max(nums[num] + rob1, rob2);
        return robInner(rob2, temp, num + 1, nums);
    }*/
}
