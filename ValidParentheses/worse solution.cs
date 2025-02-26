public class Solution
{
    public bool IsValid(string s)
    {
        var parenthesesStack = new Stack<char>();
        foreach(char ch in s)
        {
            char lastParentheses;
            switch (ch)
            {
                case '(':
                case '[':
                case '{':
                    parenthesesStack.Push(ch);
                    break;
                case ')':
                    if(parenthesesStack.Count == 0)
                        return false;
                    lastParentheses = parenthesesStack.Pop();
                    if (lastParentheses != '(')
                        return false;
                    break;
                case ']':
                    if(parenthesesStack.Count == 0)
                        return false;
                    lastParentheses = parenthesesStack.Pop();
                    if (lastParentheses != '[')
                        return false;
                    break;
                case '}':
                    if(parenthesesStack.Count == 0)
                        return false;
                    lastParentheses = parenthesesStack.Pop();
                    if (lastParentheses != '{')
                        return false;
                    break;
            }
        }

        return parenthesesStack.Count == 0;
    }
}