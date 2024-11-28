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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode current = head;
        //To get count of linkedlist
        int count = 0;
        while(current!=null)
        {
            count++;
            current= current.next;
        }
        RemoveEndNode(count-n);
        return head;
        
        void RemoveEndNode(int rem)
        {
            if(rem == 0){
                head = head.next;
                return;
            }
            var current = head;
            while(--rem>0)
            {
                current = current.next;
            }
            current.next = current.next.next;
        }
    }
    
}