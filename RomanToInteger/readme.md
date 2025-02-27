My solution did not assume that the inputs were correct at all, wrong calculations did not throw any errors.
Yet, this is a wrong approach.
By peeking into the best solution, I understood where I missed.
Also, instead of initializing default values every time an instance is created, we can utilize static instances.
This will end us up in a better memory and runtime performance.
Below is the pseudo code.
```
1. Create a dictionary `romanValues` that maps Roman numerals to their integer values.
2. Initialize `sum` to 0.
3. Iterate over the string from left to right:
   a. If the current numeral is smaller than the next one, subtract its value from `sum`.
   b. Otherwise, add its value to `sum`.
4. Return `sum`.
```