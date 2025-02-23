An improved, clear and maintainable version could be the below pseudo-code but first solution was fine.
```
FUNCTION FindFirstSubstringOccurrenceIndex(text, substring)
    IF substring IS empty
        RETURN 0

    IF text length < substring length
        RETURN -1

    maxSearchIndex = text length - substring length

    FOR index FROM 0 TO maxSearchIndex
        IF IsSubstringAtIndex(text, substring, index)
            RETURN index

    RETURN -1
END FUNCTION

FUNCTION IsSubstringAtIndex(text, substring, startIndex)
    FOR i FROM 0 TO substring length - 1
        IF text[startIndex + i] != substring[i]
            RETURN false
    RETURN true
END FUNCTION
```