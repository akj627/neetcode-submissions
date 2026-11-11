public class Solution {
    public bool IsValid(string s) {
        var dict = new Dictionary<char, char>();
        dict.Add('}', '{');
        dict.Add(')', '(');
        dict.Add(']', '[');

        var stk = new Stack<char>();
        foreach (var c in s)
        {
            if (c == '{' || c == '[' || c == '(')
                stk.Push(c);
            else if (dict.TryGetValue(c, out var val))
            {
                if (stk.Count == 0)
                    return false;

                var openB = stk.Pop();
                if (openB != val)
                    return false;
            }

        }
        return stk.Count == 0;
    }
}
