public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<List<int>>();

        for (var p0=0;p0<=nums.Length-3;p0++)
        {
            if (p0 > 0 && nums[p0] == nums[p0 - 1])
                continue;
            
            var l=p0+1;
            var r = nums.Length - 1;

            while (l < r)
            {
                if (nums[p0] + nums[l] + nums[r] == 0)
                {
                    res.Add(new List<int> {nums[p0], nums[l], nums[r]});
                    l++;
                    while (nums[l] == nums[l-1] && l < r)
                        l++;
                }
                else if (nums[p0] + nums[l] + nums[r] > 0)
                {
                    r--;
                }
                else
                {
                    l++;
                } 
            }
        }
        return res;
    }
}