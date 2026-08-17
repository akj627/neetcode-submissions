public class Solution {
    public bool IsValid(string s) {

        if (s.Length % 2 != 0)
            return false;

        var dict = new Dictionary<char,char>();
        dict.Add('}','{');
        dict.Add(')','(');
        dict.Add(']','[');

        var stk = new Stack<char>();

        foreach (var ch in s)
        {
            if (dict.ContainsKey(ch))
            {
                if (stk.Count() == 0)
                    return false;
                var pop = stk.Pop();
                if (pop != dict[ch])
                    return false;
            }
            else
            {
                stk.Push(ch);
            }
        }

        if (stk.Count() != 0)
            return false;
        return true;
    }
}
