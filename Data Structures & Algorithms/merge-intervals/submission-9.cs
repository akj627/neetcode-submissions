public class Solution {
    public int[][] Merge(int[][] intervals) {

        var res = new List<int[]>();

        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

        res.Add(intervals[0]);

        for (var i = 1;i < intervals.Length;i++)
        {
            var last = res[res.Count - 1];
            var curr = intervals[i];
            
            if (last[1] >= curr[0])
            {
                last[1] = Math.Max(last[1], curr[1]);
            }
            else
            {
                res.Add(curr);
            }
        }

        return res.ToArray();        
    }
}
