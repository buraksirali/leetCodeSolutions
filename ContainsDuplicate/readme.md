The best approach is yet again obtained by using a fitting data structure but it varies depending on the dataset size.
A reference table is below.

| Method                     | Complexity   | Overhead          | Suitable Data Size                   |
|----------------------------|--------------|-------------------|--------------------------------------|
| Dictionary.Keys.Contains   | O(n) linear  | Minimal           | Small (10-100 elements) ✅           |
| Dictionary.ContainsKey     | O(1) average | Low               | Medium-Large (>100 elements) ✅      |
| HashSet.Contains           | O(1) average | Slightly higher   | Medium-Large (best practice) ✅      |
| CollectionsMarshal         | O(1) average | Moderate          | Large-Very Large (>1,000) ✅         |

**Pseudo-code for the run-time approach**
```initialize Dictionary<TKey, bool>
foreach element in array:
    if element exists in Dictionary:
        return true
    else:
        add element with value true
return false```

or with CollectionMarshal

```initialize empty Dictionary<TKey, bool>

foreach number in array:
    // using optimized dictionary lookup
    ref var exists = GetValueRefOrAddDefault(dictionary, number, out bool existsAlready)
    if existsAlready:
        return true
    exists = true  // set value directly by reference

return false```

**Pseudo-code for the memory-wise approach**

```method ContainsDuplicate(nums):
    sort nums in-place  // QuickSort or built-in Array.Sort()

    for i from 1 to nums.length - 1:
        if nums[i] == nums[i - 1]:
            return true
    return false```