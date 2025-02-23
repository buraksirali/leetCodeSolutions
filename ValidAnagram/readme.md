My first solution this time had a good time complexity but not everything is calculated in Big O notation.
The problem I had this time was the overhead that was brought by using a Hash Table approach.
Problem is simple. It is still good to count the occurrence of characters but the characters are not unlimited like numbers. That is the catch.
We can create a limited array and use ASCII representations of characters to get indexes.
The pseudo-code for the better solution is below.
```
method IsAnagram(string s, string t):

    if lengths differ, immediately return false

    frequency array initialized to zero (size: 26)

    for i = 0 to length of strings - 1:
        increment frequency[s[i] - 'a'] by 1
        decrement frequency[t[i] - 'a'] by 1

    for each frequency count in array:
        if frequency ≠ 0:
            return false

    return true
```