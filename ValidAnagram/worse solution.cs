public class Solution {
    public bool IsAnagram(string s, string t)
    {
        var charList = new Dictionary<char, int>();
        if (s.Length != t.Length)
            return false;

        for(int i = 0; i < s.Length; i++)
        {
            var first = s[i];
            var second = t[i];

            if (charList.ContainsKey(first))
            {
                charList[first]++;
            }
            else
            {
                charList[first] = 1;
            }
            
            if (charList.ContainsKey(second))
            {
                charList[second]--;
            }
            else
            {
                charList[second] = -1;
            }
        }

        return !charList.Keys.Any(ch => charList[ch] != 0);
    }
}