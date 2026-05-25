public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var prQueue = new PriorityQueue<int, int>();

        for (var i=0;i<nums.Length;i++)
        {
            prQueue.Enqueue(nums[i], nums[i]);
            if (prQueue.Count > k)
                prQueue.Dequeue();
        }

        return prQueue.Dequeue();
    }
}
