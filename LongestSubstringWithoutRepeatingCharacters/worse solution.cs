public class Solution {
    private int _currentRun;

    private int[] _prevChars;

    public int LengthOfLongestSubstring(string s) {
        int longestRun = 0;
        this._currentRun = 0;
        this._prevChars = new int[100];
        for(int index = 0; index < s.Length; index++)
        {
            if (this._prevChars[s[index] - ' '] == 1)
            {
                if (longestRun < this._currentRun)
                {
                    longestRun = this._currentRun;
                }

                SetFieldsAfterDuplicate(s, index);
            }
            else
            {
                IncrementRun(s[index]);
            }

        }


        if (longestRun < this._currentRun)
        {
            longestRun = this._currentRun;
        }

        return longestRun;
    }

    private void SetFieldsAfterDuplicate(string word, int index)
    {
        this._currentRun = 0;
        this._prevChars = new int[100];
        for(int i = index; i >= 0; i--)
        {
            if (this._prevChars[word[i] - ' '] == 1)
            {
                return;
            }
            IncrementRun(word[i]);
        }
    }

    private void IncrementRun(char ch)
    {
        this._currentRun++;
        this._prevChars[ch - ' ']++;
    }
}