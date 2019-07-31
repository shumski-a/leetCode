/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
      string sum1 = "", sum2 = "";
      string summ = "";
        int ext = 0;
        do
        {
     
       var n1 = (l1 != null)? l1.val:0;
       var n2 = (l2 != null) ? l2.val : 0;
        int tmp = n1 + n2;
        summ = ((tmp + ext >= 10) ? (tmp + ext - 10) : tmp + ext) + summ;
        ext = (tmp + ext >= 10) ? 1 : 0;
        l1 = l1?.next;
        l2 = l2?.next;
       }
        while (l1 != null || l2 != null);
      
       if (ext > 0)
           summ = ext + summ;
        
       
        ListNode result = null;
        ListNode current = null;
        string fstr = summ; 
        for (int i = fstr.Length -1; i >= 0; i --)
        {
            if (current == null)
            {
                current = new ListNode (int.Parse(fstr[i].ToString()));
                result = current;           
            }
            else
            {
                current.next = new ListNode(int.Parse(fstr[i].ToString()));
                current = current.next;
            }
        }
    
    return result;
}
}