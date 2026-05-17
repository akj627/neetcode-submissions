public class Solution {

    public string Encode(IList<string> strs) {
        var res = new StringBuilder();
        foreach (var str in strs)
        {
            res.Append(str.Length + "#" + str);
        }
        return res.ToString();        
    }

    public List<string> Decode(string s) {
        var res = new List<string>();

        string occur = "";
        var ind = 0;
        while (ind < s.Length)
        {
            if (Char.IsDigit(s[ind]))
            {
                occur += s[ind].ToString();
                ind++;
            }
            else if (s[ind] - '0' == '#' - '0')
            {
                var occurNum = Int32.Parse(occur);
                occur = "";
                res.Add(s.Substring(ind + 1,occurNum));
                ind = ind + 1 + occurNum;
            }
        }
        return res;
   }
}
