public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var prQueue = new PriorityQueue<int[], int>();
        var res = new int[k][];

        for (var i=0;i < points.Length;i++)
        {
            var point = points[i];
            prQueue.Enqueue(point, point[0]*point[0]+point[1]*point[1]);
        }

        for (var i=0;i < k;i++)
        {
            res[i] = prQueue.Dequeue();
        }

        return res;
    }
}
