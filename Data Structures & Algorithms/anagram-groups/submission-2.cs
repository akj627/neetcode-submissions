public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dictGrp = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var cStr = new int[26];

            foreach(char c in str)
                cStr[c - 'a']++;

            string key = string.Join(",", cStr);
            if (!dictGrp.ContainsKey(key))
                dictGrp[key] = new List<string>();
            dictGrp[key].Add(str);
        }

        var lstRet = new List<List<string>>();
        foreach (var dictG in dictGrp.Keys)
        {
            lstRet.Add(dictGrp[dictG]);
        }
        return lstRet;
    }
}
