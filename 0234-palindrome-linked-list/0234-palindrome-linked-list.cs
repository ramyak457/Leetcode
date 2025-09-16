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
    public bool IsPalindrome(ListNode head) {
        ListNode curr = head;
        List<int> li = new();
        while(curr!=null)
        {
            li.Add(curr.val);
            curr = curr.next;
        }
        int mid = li.Count()/2;
        int last = li.Count()-1;
        for (int i = 0;i<=mid;i++ )
        {
            if(li[i] !=li[last--])
            {
                return false;
            }
        }
        return true;
    }
}