public class Solution {
    public int RomanToInt(string s) {
        var sum = 0;
        for(var index = 0; index < s.Length; index++)
        {
            var romanLetter = s[index];
            switch (romanLetter) {
                case ('I'):
                    if (index != s.Length - 1 && (s[index + 1].Equals('V') || s[index + 1].Equals('X')))
                    {
                        sum += s[index + 1].Equals('V')
                            ? 4
                            : 9;
                        index++;
                    }
                    else
                    {
                        sum += 1;
                    }
                    break;
                case ('V'):
                    sum += 5;
                    break;
                case ('X'):
                    if (index != s.Length - 1 && (s[index + 1].Equals('L') || s[index + 1].Equals('C')))
                    {
                        sum += s[index + 1].Equals('L')
                            ? 40
                            : 90;
                        index++;
                    } else {
                        sum += 10;
                    }
                    break;
                case ('L'):
                    sum += 50;
                    break;
                case ('C'):
                    if (index != s.Length - 1 && (s[index + 1].Equals('D') || s[index + 1].Equals('M')))
                    {
                        sum += s[index + 1].Equals('D')
                            ? 400
                            : 900;
                        index++;
                    } else {
                        sum += 100;
                    }
                    break;
                case ('D'):
                    sum += 500;
                    break;
                case ('M'):
                    sum += 1000;
                    break;
            }
        }

        return sum;
    }
}