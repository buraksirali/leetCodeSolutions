public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var commonChars = new List<char>();

        try
        {
            var firstWord = strs[0];
            for (int i = 0; i < firstWord.Length; i++)
            {
                char commonChar = firstWord[i];
                var differentPrefixExists = strs.Any(word => word[i] != commonChar);
                if (differentPrefixExists)
                    break;
                
                commonChars.Add(commonChar);
            }
        }
        catch (Exception e)
        {
        
        }

        return new string(commonChars.ToArray());
    }
}