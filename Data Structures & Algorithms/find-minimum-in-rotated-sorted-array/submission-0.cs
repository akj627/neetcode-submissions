public class Solution {
    public int FindMin(int[] nums) {
        var left = 0;
        var lastNum = nums[nums.Length - 1];
        var right = nums.Length - 1;
        var minIndex = -1;

        while (left <= right)
        {
            var mid = left + (right - left)/2;

            if (nums[mid] <= lastNum)
            {
                minIndex = mid;
                right = mid - 1;
            }
            else
                left = mid + 1;
        }

        return nums[minIndex];
    }
}
