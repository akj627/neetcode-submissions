public class LRUCache {

    private Dictionary<int, LRUNode> dictPair;
    private int capacity;

    private LRUNode head;
    private LRUNode tail;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        dictPair = new Dictionary<int, LRUNode>();

        head = new LRUNode(-1, -1);
        tail = new LRUNode(-1, -1);

        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        if (!dictPair.TryGetValue(key, out LRUNode node))
            return -1;
        
        MoveToFront(node);
        return node.val;
    }
    
    public void Put(int key, int value) {
        if (dictPair.TryGetValue(key, out LRUNode node))
        {
            node.val = value;
            MoveToFront(node);
            return;
        }
        
        if (dictPair.Keys.Count() == this.capacity)
        {
            var lru = tail.prev;
            RemoveNode(lru);
            dictPair.Remove(lru.key);
        }

        var newNode = new LRUNode(key, value);
        dictPair.Add(key, newNode);

        AddToFront(newNode);
    }

    private void MoveToFront(LRUNode node)
    {
        RemoveNode(node);
        AddToFront(node);
    }

    private void RemoveNode(LRUNode node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    private void AddToFront(LRUNode node)
    {
        node.next = head.next;
        head.next.prev = node;

        head.next = node;
        node.prev = head;
    }
}

public class LRUNode
{
    public int key;
    public int val;

    public LRUNode prev;
    public LRUNode next;

    public LRUNode(int key, int val)
    {
        this.key = key;
        this.val = val;
    }
}