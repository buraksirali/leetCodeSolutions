public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var characterFrequencyCounter = new int[26];

        for(int i = 0; i < s.Length; i++)
        {
            characterFrequencyCounter[s[i] - 'a']++;
            characterFrequencyCounter[t[i] - 'a']--;
        }

        return !characterFrequencyCounter.Any((count) => count != 0);
    }
}