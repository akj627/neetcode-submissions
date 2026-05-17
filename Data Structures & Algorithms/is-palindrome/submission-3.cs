public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !IsAlphaNum(s[left]))
                left++;

            while (left < right && !IsAlphaNum(s[right]))
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;
            left++;
            right--;
        }
        return true;        
    }

    private bool IsAlphaNum(char c)
    {
        return (c >= 'A' && c <= 'Z' ||
            c >= 'a' && c <= 'z' ||
            c >= '0' && c <= '9');
    }
}
