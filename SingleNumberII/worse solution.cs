public class Solution {
    public int SingleNumber(int[] numbers) {
        var occurrence = new Dictionary<int, int>();
        for(int i = 0; i < numbers.Length; i++) {
            if(occurrence.ContainsKey(numbers[i]))
            {
                occurrence[numbers[i]]++;
            } else {
                occurrence[numbers[i]] = 1;
            }
        }

        foreach(var item in occurrence)
            if (item.Value == 1)
                return item.Key;

        return 0;
    }
}