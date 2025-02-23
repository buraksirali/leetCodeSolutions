public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s))
            return 0;

        int longestLength = 0;
        int leftPointer = 0;
        var charIndexMap = new Dictionary<char, int>();
        for(int rightPointer = 0; rightPointer < s.Length; rightPointer++)
        {
            char currentChar = s[rightPointer];
            if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= leftPointer)
            {
                leftPointer = charIndexMap[currentChar] + 1;
            }

            charIndexMap[currentChar] = rightPointer;
            longestLength = Math.Max(longestLength, rightPointer - leftPointer + 1);
        }

        return longestLength;
    }
}