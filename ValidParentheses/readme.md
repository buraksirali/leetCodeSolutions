This time, interesting enough, I've come up with the better solutions and not ChatGPT.
This was a simple task and it required little to no overhead as much as possible. People
did this using Span and other memory safe tactics so their solutions could surpass my speed but it is alright.
Below is the recommended pseudo-code of the method I told ChatGPT.
```
pseudo-code START

FUNCTION IsValidParentheses(inputString):
    // We'll allocate a stack array as large as the input
    // because we know the maximum unmatched parentheses
    // can be equal to the length of the string.
    DEFINE stack as array of characters with length = lengthOf(inputString)
    DEFINE topIndex = -1  // indicates an empty stack

    FOR i from 0 to lengthOf(inputString) - 1:
        DEFINE currentChar = inputString[i]

        IF currentChar is '(' or '[' or '{':
            // push
            topIndex = topIndex + 1
            stack[topIndex] = currentChar

        ELSE IF currentChar is ')' or ']' or '}':
            IF topIndex < 0:
                // There's no corresponding open bracket
                RETURN false

            DEFINE lastOpen = stack[topIndex]
            topIndex = topIndex - 1

            // Check matching pairs directly
            IF (currentChar == ')' AND lastOpen != '('):
                RETURN false
            IF (currentChar == ']' AND lastOpen != '['):
                RETURN false
            IF (currentChar == '}' AND lastOpen != '{'):
                RETURN false

    // If there are unclosed brackets, stack won't be empty
    RETURN (topIndex == -1)

pseudo-code END
```