public class Solution {
    public bool hasDuplicate(int[] nums) {
        var setDupe = new HashSet<int>();

        foreach (int i in nums)
        {
            if (setDupe.Contains(i))
                return true;
            setDupe.Add(i);
        }
        return false;
    }       
}