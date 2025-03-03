Claude recommends a very useful and easy solution, Dynamic Programming.
Sometimes, writing down the problem and seeing what we need to do helps.
Below is the pseudo code.

```
function CountBits(n):
    create result array of size n+1
    
    result[0] = 0  // Base case
    
    for i from 1 to n:
        // Option 1: Using the relationship with i/2
        result[i] = result[i >> 1] + (i & 1)
        
        // Or Option 2: Using the relationship with i & (i-1)
        // result[i] = result[i & (i-1)] + 1
    
    return result
```