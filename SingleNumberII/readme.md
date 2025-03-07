The best solution is very hard to grasp and it requires advanced bitwise operation
knowledge to pull off. Still, I think my solution does well. This is the kind of
optimization that can be made in a situation where we need to optimize a case by a
large margin. Thankfully, AI exists now.
Below is the solution.
```
function SingleNumber(nums):
    ones = 0
    twos = 0
    
    for each num in nums:
        // Update first and second appearance counters
        ones = (ones XOR num) AND (NOT twos)
        twos = (twos XOR num) AND (NOT ones)
    
    return ones  // Contains the number that appears once
``` 