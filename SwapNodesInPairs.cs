/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
            if (head == null || head.next == null)
                return head;
            var result = head.next;
            var current = head;
            ListNode previousEnd = result;
            while (current != null && current.next != null)
            {
                var tmp = current;
                
                var tmp3 = current.next.next;
                current = current.next;
                previousEnd.next = current;
                current.next = tmp;
                tmp.next = tmp3;
                previousEnd = current.next;
                current = tmp3;
            }
            return result;
    }
}