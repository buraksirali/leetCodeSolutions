My solution did solve the problem but did it so slowly. Suggested pseudo-code implementation is way much more solid and
I should read it, then understand how the algorithm is built and how it works.

```
METHOD LengthOfLongestSubstring(inputString):
    IF inputString is empty:
        RETURN 0

    SET longestLength = 0
    SET leftPointer = 0
    SET charIndexMap = new Dictionary<char, int>()

    FOR each character at position rightPointer from 0 to inputString.length - 1:
        currentChar = inputString[rightPointer]

        IF charIndexMap has currentChar AND charIndexMap[currentChar] >= leftPointer:
            MOVE leftPointer right after the duplicate char position (charIndexMap[currentChar] + 1)

        UPDATE charIndexMap with current character's latest position (rightPointer)

        CALCULATE longestLength as the maximum of (previous longestLength) and (current window size: rightPointer - leftPointer + 1)

    RETURN longestLength
```