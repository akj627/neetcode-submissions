public class KthLargest {
    int k;
    PriorityQueue<int, int> prQ;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        prQ = new PriorityQueue<int, int>();

        foreach (var n in nums)
        {
            Enqueue(n);
        }
    }
    
    public int Add(int val) {
        Enqueue(val);
        
        return prQ.Peek();
    }

    public void Enqueue(int n)
    {
        prQ.Enqueue(n, n);
        if (prQ.Count > k)
            prQ.Dequeue();
    }
}
