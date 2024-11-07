/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        if(node == null){return;}
        node.val = node.next==null? 0: node.next.val;
        node.next = node.next.next == null? null: node.next.next;
       
        
    }
}