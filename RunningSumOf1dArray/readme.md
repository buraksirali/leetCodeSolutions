This problem has only one solution because well, it is the best one.
A simple memory and execution problem which is not very complex.
Below is the pseudo-code recommended.
```
// Instead of creating a new array
// Just modify the input array directly
// Start from index 1 since index 0 stays the same
For each index i from 1 to nums.Length-1:
    nums[i] = nums[i-1] + nums[i]
Return nums
```