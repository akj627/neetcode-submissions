public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1)
            return intervals;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var result = new List<int[]>();
        result.Add(intervals[0]);

        for (var i = 1; i < intervals.Length; i++)
        {
            var last = result[result.Count - 1];
            var curr = intervals[i];

            if (curr[0] <= last[1])
                last[1] = Math.Max(curr[1], last[1]);
            else
                result.Add(curr);
        }

        return result.ToArray();
    }
}
