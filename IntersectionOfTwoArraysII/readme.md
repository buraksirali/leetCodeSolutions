First solution iterated with O(M x N) worst case so it was not very efficient.

Using a Hash-Table or Dictionary to count, increment and decrement values to return a result is very useful.
This approach makes it so the worst case is lowered down to O(M + N).
Below is the pseudo-code.
```
METHOD intersect(array nums1, array nums2):
    IF length(nums1) > length(nums2):
        swap(nums1, nums2)    // Hash the smaller array for better memory optimization
    
    CREATE mapCounter as empty dictionary (number → frequency)
    CREATE result as empty list

    FOR EACH num IN nums1:
        IF num EXISTS in mapCounter:
            INCREMENT mapCounter[num] by 1
        ELSE:
            SET mapCounter[num] to 1

    FOR EACH num IN nums2:
        IF num EXISTS in mapCounter AND mapCounter[num] > 0:
            ADD num TO result
            DECREMENT mapCounter[num] by 1

    RETURN result as array
```

Further optimizations are possible by making the code more complex and utilizing additional features of the language we want.
Below are the recommended pseudo codes.
```
// Result Creation, only refactors IntersectWithCounter method.
METHOD IntersectWithCounter(mapCounter, nums):
    SET resultSize TO 0

    FOR EACH num IN nums:
        IF mapCounter CONTAINS num AND mapCounter[num] > 0:
            INCREMENT resultSize
            DECREMENT mapCounter[num]

    ALLOCATE resultArray with size = resultSize
    RESET mapCounter counts based on previous logic

    SET index TO 0
    FOR EACH num IN nums:
        IF mapCounter[num] EXISTS AND mapCounter[num] > 0:
            SET resultArray[index] TO num
            DECREMENT mapCounter[num]
            INCREMENT index

    RETURN resultArray
```

```
// Using Span<T> and Array Pooling in .Net 8 to optimize it further
METHOD intersect(nums1, nums2):
    SELECT smaller and larger arrays as Span<int> based on their length
    
    CREATE counter dictionary from smaller Span<int>
    RENT result array from ArrayPool<int>
    
    FOR EACH num IN larger Span<int>:
        IF num IN counter AND counter[num] > 0:
            ADD num TO pooled result array
            DECREMENT counter[num]
    
    RETURN pooled result array with exact length
    RETURN array to pool after usage
```