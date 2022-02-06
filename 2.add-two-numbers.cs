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
        ListNode result = null;
        ListNode tail = null;
        var sum = 0;
        var remainder = 0;

        while (l1 != null && l2 != null)
        {
            sum = l1.val + l2.val + remainder;
            remainder = sum / 10;
            sum = sum % 10;
            if (tail != null)
            {
                tail.next = new(sum);
                tail = tail.next;
            }
            else
                tail = new(sum);
            if (result == null)
                result = tail;
            l1 = l1.next;
            l2 = l2.next;
        }
        while (l1 != null)
        {
            sum = l1.val + remainder;
            remainder = sum / 10;
            sum = sum % 10;
            if (tail != null)
            {
                tail.next = new(sum);
                tail = tail.next;
            }
            else
                tail = new(sum);
            if (result == null)
                result = tail;
            l1 = l1.next;
        }
        while (l2 != null)
        {
            sum = l2.val + remainder;
            remainder = sum / 10;
            sum = sum % 10;
            if (tail != null)
            {
                tail.next = new(sum);
                tail = tail.next;
            }
            else
                tail = new(sum);
            if (result == null)
                result = tail;
            l2 = l2.next;
        }
        if (remainder != 0)
        {
            tail.next = new(remainder);
            tail = tail.next;
        }
        return result;
    }
}
// @lc code=end

