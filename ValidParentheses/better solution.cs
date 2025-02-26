public class Solution
{
    public bool IsValid(string s)
    {
        var parenthesesStack = new char[s.Length];
        var topIndex = -1;
        for(int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (ch.Equals('(') || ch.Equals('[') || ch.Equals('{'))
            {
                parenthesesStack[++topIndex] = ch;
                continue;
            }

            if (ch.Equals(')') || ch.Equals(']') || ch.Equals('}'))
            {
                if (topIndex < 0)
                    return false;
                var lastOpen = parenthesesStack[topIndex--];

                if (ch.Equals(')') && !lastOpen.Equals('('))
                    return false;
                if (ch.Equals(']') && !lastOpen.Equals('['))
                    return false;
                if (ch.Equals('}') && !lastOpen.Equals('{'))
                    return false;
            }
        }

        return topIndex == -1;
    }
}