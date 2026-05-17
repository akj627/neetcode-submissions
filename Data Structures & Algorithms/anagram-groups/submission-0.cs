public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dictGrp = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] cStr = str.ToCharArray();
            Array.Sort(cStr);
            string sorted = new string(cStr);
            if (dictGrp.ContainsKey(sorted))
                dictGrp[sorted].Add(str);
            else
                dictGrp.Add(sorted, new List<string> {str});
        }

        var lstRet = new List<List<string>>();
        foreach (var dictG in dictGrp.Keys)
        {
            lstRet.Add(dictGrp[dictG]);
        }
        return lstRet;
    }
}
