/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        List<int> ans = new List<int>();
        while(l1 != null)
        {
            ans.Add(l1.val);
            l1 = l1.next;
        }
        while(l2 != null)
        {
            ans.Add(l2.val);
            l2 = l2.next;
        }
        ans = ans.OrderBy(x => x).ToList();
        if(ans.Count == 0)
            return null;
        ListNode ansNode = new ListNode(ans.First());
        ListNode now = ansNode;
        for(int i = 1;i<ans.Count;i++)
        {
            now.next = new ListNode(ans[i]);
            now = now.next;
        }
        return ansNode;
    }
}