public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // 1,1 2,2
        //5,5 4,4

        var pq = new PriorityQueue<int, int>();
        var res = -1001;

        foreach (var i in nums)
        {
            pq.Enqueue(i, i);
            if (pq.Count > k)
                pq.Dequeue();
        }

        res = pq.Dequeue();

        return res;
    }
}
