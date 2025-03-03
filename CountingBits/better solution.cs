public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n + 1];
        result[0] = 0;
        for(int i = 1; i <= n; i++)
        {   
            result[i] = result[i >> 1] + (i % 2);
        }

        return result;
    }

}