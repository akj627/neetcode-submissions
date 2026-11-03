public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        // 1   4
        //    3    5
        //        4  7


        // 1 7

        if (intervals.Length <= 1)
            return intervals;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        
        var res = new List<int[]>();
        var lastMin = intervals[0][0];
        var lastMax = intervals[0][1];

        for (var i = 1;i < intervals.Length;i++)
        {
            if (lastMax >= intervals[i][0])
            {
                lastMin = Math.Min(lastMin, intervals[i][0]);
                lastMax = Math.Max(lastMax, intervals[i][1]);
            }
            else
            {
                res.Add(new int[] {lastMin, lastMax});
                lastMin = intervals[i][0];
                lastMax = intervals[i][1];
            }
        }

        res.Add(new int[] {lastMin, lastMax});
        return res.ToArray();
    }
}
