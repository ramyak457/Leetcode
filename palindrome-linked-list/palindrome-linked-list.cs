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
        List<int> li = new List<int>();
        while(head!=null)
        {
            li.Add(head.val);
            head = head.next;
        }
        int len = li.Count;
        int mid = len/2;
        int last = len-1;
        for(int i=0;i<mid;i++)
        {
            if(li[i]!=li[last])
            {
                return false;
            }
            last--;
        }
        return true;
    }
}