public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}



public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        
        ListNode result = null;

        var firstPointer = list1;
        var secondPointer = list2;

        if (firstPointer == null)
        {
            return secondPointer;
        }
        else if (secondPointer == null)
        {
            return firstPointer;
        }
        while (secondPointer != null)
        {
            if (firstPointer == null)
            {
                break;
            }
            if (firstPointer.val < secondPointer.val)
            {
                if (result == null)
                {
                    result = new ListNode(firstPointer.val);
                }
                else
                {
                    result = AddToEnd(result, firstPointer.val);
                }
                firstPointer = firstPointer.next;
            }
            else
            {
                var temp = secondPointer.next;
                secondPointer.next = firstPointer;
                firstPointer = secondPointer;
                secondPointer = temp;
            }
        }

        if (result == null)
        {
            result = new ListNode(firstPointer.val, firstPointer.next);
        }
        else
        {
            AddToEnd(result, firstPointer ?? secondPointer);
        }

        return result;
    }

    private ListNode AddToEnd(ListNode node, int val)
    {
        var pointer = node;
        while (true)
        {
            if (pointer.next == null)
            {
                pointer.next = new ListNode(val);
                break;
            }
            pointer = pointer.next;
        }

        return node;
    }
    
    private ListNode AddToEnd(ListNode node, ListNode val)
    {
        if (val == null)
        {
            return node;
        }
        var pointer = node;
        while (true)
        {
            if (pointer.next == null)
            {
                pointer.next = val;
                break;
            }
            pointer = pointer.next;
        }

        return node;
    }
}