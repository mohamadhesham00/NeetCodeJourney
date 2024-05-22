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
    // As it's FIFO, we will store values in the queue to reverse them later
    Queue<int>queue = new Queue<int>();
    public ListNode ReverseList(ListNode head) {
        // Ensure the linked list isn't empty
        if(head != null){
            queue.Enqueue(head.val);
            // Check if the current node is not the tail
            if(head.next != null){
                // Recursively call ReverseList for the next node
                ReverseList(head.next);
            }
            // Dequeue and assign the reversed value if the queue is not empty
            if(queue.Count() != 0){
                int reversedValue = queue.Dequeue();
                head.val = reversedValue;
            }
        }
        return head;
    }
}