public class KthLargest {
    int k;
    int[] nums;
    PriorityQueue<int, int> prQ;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.nums = nums;
        prQ = new PriorityQueue<int, int>();

        foreach (var n in nums)
            Enqueue(n);
    }
    
    public int Add(int val) {
        Enqueue(val);

        while (prQ.Count > k)
            prQ.Dequeue();
            
        return prQ.Peek();
    }

    public void Enqueue(int val)
    {        
        prQ.Enqueue(val, val);//4 5 8 2 3
    }
}
