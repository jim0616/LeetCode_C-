/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
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

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        bool next = false;
        int res = 0;
       
        
        //first init
        ListNode resNode = new ListNode();
        ListNode copyNode = new ListNode();
        
        res = l1.val+l2.val;
        if(res>9)
        {
            next = true;
            res -=10;
        }
        resNode.val = res;
        copyNode = resNode;
        
        l1 = l1.next;
        l2 = l2.next;
        
        //start iteration
        while(l1!=null || l2!=null)
        {
            
            int tmp1 = 0;
            int tmp2 = 0;
            
            if(l1!=null)
            {
                tmp1 = l1.val;
                l1 = l1.next;
            }
            
            if(l2!=null)
            {
                tmp2 = l2.val;
                l2 = l2.next;
            }
            
            res = tmp1+tmp2;
            if(next)
            {
                res+=1;
                next = false;
            }
            
            if(res>9)
            {
                next = true;
                res -=10;
            }

            ListNode newNode = new ListNode();
            newNode.val = res;
            copyNode.next = newNode;
            copyNode = newNode;
            
        }
        
        if(next)
        {
            ListNode newNode = new ListNode();
            newNode.val = 1;
            copyNode.next = newNode; 
        }
        
    return resNode;
    }
}
// @lc code=end

