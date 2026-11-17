public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var l = 1;

        for (var r = 1; r < nums.Length;r++)
        {
            if (nums[r] != nums[r - 1])
            {
                nums[l] = nums[r];
                l++;
            }
        }

        return l;
    }
}