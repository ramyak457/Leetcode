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
    public ListNode ReverseKGroup(ListNode head, int k) {
        //Solution 1
        ListNode curr = head; 
        List<int> li = new List<int>();
        while(curr!=null)
        {
            li.Add(curr.val);
            curr = curr.next;
        }
        int l=0, cnt =0;
        for(int i=0;i<li.Count();i++)
        {
            cnt++;
            if(cnt == k)
            {
                int r =i;
                while(l<r)
                {
                    int tmp = li[r];
                    li[r] = li[l];
                    li[l] = tmp;
                    l++; r--;

                }
                cnt  = 0;
                l = i+1;
            }
        }
        //Convert from list to linkedinlist
        ListNode head1 = null, curr1 = null;
        foreach(int i in li)
        {
            ListNode tmp = new ListNode(i);
            if(head1 == null)
            { 
                head1 = tmp; 
                curr1 = tmp;           
            } 
            else{
                    curr1.next = tmp;         
                    curr1 = curr1.next;
            } 

        }
        return head1;
    }
}