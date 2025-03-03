public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n + 1];
        for(int i = 0; i <= n; i++)
        {   
            result[i] = CountOnes(i);
        }

        return result;
    }

    public int CountOnes(int n) {
        var count = 0;
        while (n > 0) {
            count += n % 2;
            n = n / 2;
        }

        return count;
    }
}