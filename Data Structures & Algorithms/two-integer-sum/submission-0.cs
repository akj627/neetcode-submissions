public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictSum = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            //4,0-3,1-2,2-1,3

            if (dictSum.ContainsKey(nums[i]))
                return new int[] {dictSum[nums[i]], i};
            else
                dictSum.Add(diff, i);
        }

        return new int[0];
    }
}