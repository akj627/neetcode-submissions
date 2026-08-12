public class Solution {
    public bool IsArraySpecial(int[] nums) {
        for (var i=0; i < nums.Length - 1;i++)
        {
            var num1 = nums[i];
            var num2 = nums[i+1];

            if ((num1 + num2) % 2 == 0)
                return false;
        }
        return true;
    }
}