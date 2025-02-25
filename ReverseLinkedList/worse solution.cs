public class Solution {
    public ListNode ReverseList(ListNode head) {
        var newHead = new ListNode();
        
        while (head != null)
        {
            var temp = newHead.next;
            newHead.next = new ListNode(head.val, head.next);
            if (newHead.next != null)
            {
                newHead.next.next = temp;
            }

            head = head.next;
        }

        return newHead.next;
    }
}