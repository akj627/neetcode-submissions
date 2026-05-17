public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            for (var i = left;i < right;i++)
            {
                if (!char.IsLetterOrDigit(s[i]))
                    left++;
                else
                    break;
            }

            for (var i = right;i > left;i--)
            {
                if (!char.IsLetterOrDigit(s[i]))
                    right--;
                else
                    break;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;
            left++;
            right--;
        }
        return true;        
    }
}
