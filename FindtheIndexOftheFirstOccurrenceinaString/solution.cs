public class Solution {
    public int StrStr(string word, string subStr)
    {
        var firstChar = subStr[0];
        var index = GetNextIndex(word, firstChar, 0);
        while (index <= word.Length - subStr.Length)
        {
            var foundWord = CheckWord(word, subStr, index);
            if (foundWord)
                return index;
            index = GetNextIndex(word, firstChar, index + 1);
        }

        return -1;
        
    }

    public bool CheckWord(string word, string subStr, int startIndex)
    {
        for(int i = 1; i < subStr.Length; i++)
        {   
            if (subStr[i] != word[startIndex + i])
            {
                return false;
            }
        }
        return true;
    }

    public int GetNextIndex(string word, char ch, int index)
    {
        for(int i = index; i < word.Length; i++)
        {
            if (ch == word[i])
                return i;
        }

        return word.Length;
    }

}