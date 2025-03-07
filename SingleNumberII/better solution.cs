public class Solution {
    public int SingleNumber(int[] numbers) {
        int ones = 0;
        int twos = 0;

        foreach(int num in numbers)
        {
            ones = (ones ^ num) & ~twos;
            twos = (twos ^ num) & ~ones;
        }

        return ones;
    }
}