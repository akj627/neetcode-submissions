public class Solution {
    public bool IsPalindrome(string s) {
        var l = 0;
        var r = s.Length - 1;
        while (l < r)
        {
            while (!IsAlphaNum(s[l]) && l < r)
                l++;

            while (!IsAlphaNum(s[r]) && l < r)
                r--;

            if (char.ToLower(s[l]) != char.ToLower(s[r]))
                return false;

            l++;
            r--;
        }

        return true;
    }

    public bool IsAlphaNum(char c)
    {
        if (c - 'a' >= 0 && c - 'a' <= 26)
            return true;

        if (c - 'A' >= 0 && c - 'A' <= 26)
            return true;

        if (c - '0' >= 0 && c - '0' <= 9)
            return true;

        return false;
    }
}
