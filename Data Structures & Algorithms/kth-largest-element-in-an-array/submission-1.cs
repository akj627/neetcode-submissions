public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // -5,5 -4,4 -3, 3 -2,2 -1,1 

        var pq = new PriorityQueue<int, int>();
        var res = -1001;

        foreach (var i in nums)
        {
            pq.Enqueue(i, -i);
        }

        for (var i = 0; i < k;i++)
        {
            res = pq.Dequeue();
        }

        return res;
    }
}
