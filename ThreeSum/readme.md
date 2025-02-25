My solution couldn't even solve the case because it was working so slow.
In these types of problems, if the solution is way too complex, sorting the
array first helps a lot. Having O(nlogn) + O(n^2) is much better than O(n^3).
Next time, I should assess the complexity first by BigO numbers and approach the question
with that mindset.
After sorting, dealing with duplicates is the easiest thing.
Below is the pseudo code for 3Sum.
```
1. sort the input array -> numbers

2. initialize an empty list named result

3. for i in range(0 to numbers.length - 2)
    if i > 0 and numbers[i] == numbers[i - 1]
        continue // skip this i to avoid duplicates

    left = i + 1
    right = numbers.length - 1

    while left < right
        currentSum = numbers[i] + numbers[left] + numbers[right]

        if currentSum < 0
            move left pointer to the right (left++)
        else if currentSum > 0
            move right pointer to the left (right--)
        else
            // currentSum == 0, record the triplet
            add [numbers[i], numbers[left], numbers[right]] to result

            // move left pointer
            left++

            // skip duplicate values for left pointer
            while left < right and numbers[left] == numbers[left - 1]
                left++

            // similarly move and skip duplicates for right pointer
            right--
            while left < right and numbers[right] == numbers[right + 1]
                right--

4. return result
```