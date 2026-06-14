public class Solution {
    public int CharacterReplacement(string s, int k) {
        var left = 0;
        var right = 0;
        var hashLen = new Dictionary<int,int>();
        var maxLen = 0;

        while (right < s.Length)
        {
            var charType = s[right] - 'A';

            if (hashLen.ContainsKey(charType))
                hashLen[charType]++;
            else
                hashLen.Add(charType, 1);

            var maxOccur = 0;
            foreach (var dictKey in hashLen.Keys)
                maxOccur = Math.Max(maxOccur, hashLen[dictKey]);
            
            if (right - left + 1 - maxOccur > k)
            {
                hashLen[s[left] - 'A']--;
                hashLen[s[right] - 'A']--;
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
