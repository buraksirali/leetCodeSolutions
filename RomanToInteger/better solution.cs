public class Solution {
    public static int[] romanValues = new int[22];

    static Solution()
    {
        romanValues['I' - 'C'] = 1;
        romanValues['V' - 'C'] = 5;
        romanValues['X' - 'C'] = 10;
        romanValues['L' - 'C'] = 50;
        romanValues['C' - 'C'] = 100;
        romanValues['D' - 'C'] = 500;
        romanValues['M' - 'C'] = 1000;
    }

    public int RomanToInt(string s) {
        int currentValue = romanValues[s[0] - 'C'];
        int sum = currentValue;
        int previousValue = currentValue;
        for(var index = 1; index < s.Length; index++)
        {
            currentValue = romanValues[s[index] - 'C'];
            sum += currentValue;

            if (currentValue > previousValue)
            {
                sum -= previousValue * 2;
            }
            
            previousValue = currentValue;
        }

        return sum;
    }
}