public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode previousNode = null;
        var currentNode = head;
        
        while (currentNode != null)
        {
            var nextNode = currentNode.next;
            currentNode.next = previousNode;

            previousNode = currentNode;
            currentNode = nextNode;
        }

        return previousNode;
    }
}