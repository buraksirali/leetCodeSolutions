This was so much of a roller coaster for me. I had a solution which was not the best and was way too complex.
Then the solution recommended by chatgpt made so much sense but I don't think it is easy to come up with an algorithm like this
at the first try. I should totally revise this from now on.

Below is the pseudo code.
```
function MergeTwoSortedLists(list1, list2):

    // 1. Handle null edge cases
    if list1 is null:
        return list2
    if list2 is null:
        return list1

    // 2. Initialize a dummy node and tail pointer
    create dummyHead node
    set tail = dummyHead

    // 3. Merge by choosing from list1 or list2
    while list1 is not null and list2 is not null:
        if list1's value <= list2's value:
            attach list1 to tail
            move list1 = list1.next
        else:
            attach list2 to tail
            move list2 = list2.next

        move tail = tail.next

    // 4. Attach the remainder
    if list1 is not null:
        tail.next = list1
    if list2 is not null:
        tail.next = list2

    // 5. Return merged list
    return dummyHead.next
```