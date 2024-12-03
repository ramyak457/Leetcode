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
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }
        ListNode i = head,
                 j = i.next,
                 k = j.next;

        i.next = null;
        while(j!=null)
        {
            j.next = i;
            i = j;
            j = k;
            if(j!=null){
                k = j.next;
            }
        }
        return i;        
    }
}