public class Solution {
    public int StrStr(string haystack, string needle) {
        
        var i = 0;
        var l = 0;
        var ind = -1;
        var found = false;

        while(true)
        {
            if (i == needle.Length || l == haystack.Length)
                return -1;
            if (needle[i] == haystack[l])
            {
                found = true;
                if (i == 0)
                    ind = l;
                l++;
                i++;
                if (i == needle.Length)
                    return ind;
            }
            else
            {
                i = 0;
                if (found)
                {
                    l = ind + 1;
                    found = false;

                }           
                else
                {
                    l++;
                }

            }
        }

        return -1;
    }//neecodeneetcode. neet
}