/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0 || lists[0] == null)
            return null;

        var l1 = lists[0];

        for (var i=1;i < lists.Length;i++)
        {
            l1 = MergeTwoLists(l1, lists[i]);
        }

        return l1;
    }

    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
    private ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var dummy = new ListNode(0);

        var res = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                res.next = list1;
                list1 = list1.next;
            }
            else
            {
                res.next = list2;
                list2 = list2.next;
            }
            res = res.next;
        }

        if (list1 != null)
            res.next = list1;
        else if (list2 != null)
            res.next = list2;

        return dummy.next;
    }
}
