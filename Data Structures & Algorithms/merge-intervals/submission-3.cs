public class Solution {
    public int[][] Merge(int[][] intervals) {

        if (intervals.Length <= 1)
            return intervals;

        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        var res = new List<int[]>();
        res.Add(intervals[0]);

        for (var i = 1; i < intervals.Length;i++)
        {
            var last = res[res.Count() - 1];
            var curr = intervals[i];

            if (curr[0] <= last[1])
                last[1] = Math.Max(last[1], curr[1]);
            else
                res.Add(curr);
        }

        return res.ToArray();
    }
}
