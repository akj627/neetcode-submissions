/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        if (intervals.Count == 0)
            return 0;

        intervals.Sort((a,b) => a.start.CompareTo(b.start));

        var pq = new PriorityQueue<int, int>();
        pq.Enqueue(intervals[0].end, intervals[0].end);

        for (var i=1;i < intervals.Count;i++)
        {
            var current = intervals[i];

            pq.TryPeek(out int earliestEnd, out _);
            if (current.start >= earliestEnd)
                pq.Dequeue();

            pq.Enqueue(current.end, current.end);            
        }

        return pq.Count;
    }
}
