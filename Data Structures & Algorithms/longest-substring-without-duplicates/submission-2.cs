public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // start at left till right and as soon as you see the same
        // character, record the length and then remove chars till you reach the same char from the set

        var left = 0;
        var right = 0;
        var maxLen = 0;
        var sNum = new HashSet<int>();
        while (right < s.Length)
        {
            while (sNum.Contains(s[right]))
            {
                sNum.Remove(s[left]);
                left++;
            }
            sNum.Add(s[right]);
            maxLen = Math.Max(right - left + 1, maxLen);
            right++;
        }

        return maxLen;
    }
}
