public class Solution {
    public bool ValidPalindrome(string s) {
        var l = 0;
        var r = s.Length - 1;

        while (l < r)
        {
            if (s[l] != s[r])
            {
                return IsPalin(s, l + 1, r) || IsPalin(s, l, r - 1);
            }
            l++;
            r--;
        }

        return true;
    }

    public bool IsPalin(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l] != s[r])
                return false;
            l++;
            r--;
        }

        return true;
    }
}