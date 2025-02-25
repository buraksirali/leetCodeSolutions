I'm really impressed by the answer. 
I could solve the problem myself without any help but it wasn't performing best. ;
Thinking about the problem more and getting used to these types of solutions is the way to improve.
Below is the pseudo code.

```
SET previousNode = null
SET currentNode = head

WHILE currentNode != null
    // Temporarily store the next node
    SET nextNode = currentNode.next

    // Reverse the link
    currentNode.next = previousNode

    // Advance pointers
    previousNode = currentNode
    currentNode = nextNode

END WHILE

// 'previousNode' now points to the new head of the reversed list
RETURN previousNode
```