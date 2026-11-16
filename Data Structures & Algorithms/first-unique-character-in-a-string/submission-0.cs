public class Solution {
    public int FirstUniqChar(string s) {
        var set = new int[26];

        var index = -1;
        foreach (var c in s)
        {
            var ch = c - 'a';
            set[ch] += 1;            
        }

        for (var i = 0;i < s.Length;i++)
        {
            var ch = s[i] - 'a';

            if (set[ch] == 1)
                return i;            
        }

        return index;
    }
}