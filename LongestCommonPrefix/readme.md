My first solution was messy but was a good approach.
The next solution was more readable, understandable and overall a much better one though.
Sometimes it seems like we have too much of an overhead but not always.
Below is the pseudo-code for the better solution.
```
Method FindLongestCommonPrefix(words):
    // Handle invalid input first
    if words is null or empty:
        return ""

    prefix = first word in words

    // Iterate over remaining words
    foreach word in words:
        prefix = CommonPrefixBetween(prefix, word)
        if prefix becomes empty:
            break
    
    return prefix

// Helper method to get common prefix between two words
Method CommonPrefixBetween(word1, word2):
    minLength = minimum length of word1 and word2
    commonPrefix = empty string

    for i from 0 to minLength:
        if word1[i] equals word2[i]:
            append word1[i] to commonPrefix
        else:
            break loop

    return commonPrefix
```

There are also many recommendations from ChatGPT.
For example, generalized efficient steps for string problems are below.
```
Method SolveStringProblem(inputs):
    Validate inputs and handle edge cases early
    Initialize optimal data structure (e.g., StringBuilder)

    foreach input in inputs:
        perform minimal, efficient operations
        avoid unnecessary allocations
        terminate early if possible

    return solution
```

Also, below are the best practice reminders.
| Do ✅                                    | Avoid 🚫                              |
|------------------------------------------|---------------------------------------|
| Validate inputs explicitly               | Empty catch blocks                    |
| Early returns on trivial edge-cases      | Exceptions for normal logic flow      |
| StringBuilder for repetitive concatenation | String concatenation in loops       |
| Separate responsibilities into methods   | Complex, long, monolithic methods     |
| Clear naming conventions                 | Abbreviations or unclear names        |
