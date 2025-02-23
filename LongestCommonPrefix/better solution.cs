public class Solution {
    public string LongestCommonPrefix(string[] words) {
        var prefix = words[0];

        foreach(string word in words)
        {
            prefix = GetCommonPrefixBetween(prefix, word);
            if (string.IsNullOrWhiteSpace(prefix))
            {
                break;
            }
        }

        return prefix;
    }

    public string GetCommonPrefixBetween(string word1, string word2)
    {
        int minLength = word1.Length < word2.Length
            ? word1.Length
            : word2.Length;

        var commonPrefix = new StringBuilder();

        for(int i = 0; i < minLength; i++)
        {
            if (word1[i].Equals(word2[i]))
                commonPrefix.Append(word1[i]);
            else
                break;
        }

        return commonPrefix.ToString();
    }
}