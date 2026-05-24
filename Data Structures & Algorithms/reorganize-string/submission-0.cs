public class Solution {
    public string ReorganizeString(string s) {

        var freq = new int[26];

        foreach (var c in s)
            freq[c - 'a']++;
        
        var pq = new PriorityQueue<char, int>();

        for (var i=0;i < 26;i++)
        {
            if (freq[i] > 0)
                pq.Enqueue ((char)('a' + i), -freq[i]);
        }

        char lastChar = '\0';
        var sb = new StringBuilder();

        while (pq.Count > 0)
        {
            pq.TryDequeue (out char char1, out int prior1);

            if (char1 != lastChar)
            {
                sb.Append (char1);
                lastChar = char1;
                if (prior1 + 1 != 0)
                    pq.Enqueue(char1, prior1 + 1);
            }
            else
            {                
                if (pq.Count == 0) return "";

                pq.TryDequeue (out char char2, out int prior2);
                sb.Append (char2);
                lastChar = char2;
                if (prior2 + 1 != 0)
                    pq.Enqueue(char2, prior2 + 1);       
                pq.Enqueue(char1, prior1);
            }
        }
        return sb.ToString();
    }
}