public class Solution {
    public int[][] Merge(int[][] intervals) {

        var res = new List<int[]>();

        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

        res.Add(intervals[0]);

        for (var i = 1;i < intervals.Length;i++)
        {
            var lastEnd = res[res.Count - 1][1];

            if (lastEnd >= intervals[i][0])
            {
                res[res.Count - 1][1] = Math.Max(lastEnd, intervals[i][1]);
            }
            else
            {
                res.Add(intervals[i]);
            }
        }

        return res.ToArray();        
    }
}
