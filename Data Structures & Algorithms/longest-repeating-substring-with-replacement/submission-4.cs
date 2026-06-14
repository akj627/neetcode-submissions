public class Solution {
    public int CharacterReplacement(string s, int k) {
        var left = 0;
        var right = 0;
        var count = new int[26];
        var maxLen = 0;
        var maxOccur = 0;

        while (right < s.Length)
        {
            var charType = s[right] - 'A';

            count[charType]++;

            maxOccur = Math.Max(maxOccur, count[charType]);
            
            if (right - left + 1 - maxOccur > k)
            {
                count[s[left] - 'A']--;
                count[s[right] - 'A']--;
                left++;
            }
            else
            {
                maxLen = Math.Max(maxLen, right - left + 1);
                right++;
            }
        }

        return maxLen;
    }
}
