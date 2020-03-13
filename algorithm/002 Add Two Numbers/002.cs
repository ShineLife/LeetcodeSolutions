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
        ListNode ans = new ListNode(0);
        ListNode a = l1;    
        ListNode b = l2;
        ListNode current = ans;
        int number = 0;
        while(a != null || b != null)
        {
            int a1 = (a != null) ? a.val : 0;            
            int b1 = (b != null) ? b.val : 0;
            int sum = number + a1 + b1;
            number = (int)(sum / 10);
            current.next = new ListNode(sum % 10);
            current = current.next;
            if(a != null) a = a.next;
            if(b != null) b = b.next;
        }
        if(number > 0)
            current.next = new ListNode(number);
        return ans.next;
    }
}