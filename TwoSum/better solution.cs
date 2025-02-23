public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var complements = new Dictionary<int, int>();
        for(int firstNumIndex = 0; firstNumIndex < nums.Length; firstNumIndex++) {
            var currentNumber = nums[firstNumIndex];
            var neededNumber = target - currentNumber;

            if (complements.Keys.Contains(neededNumber))
            {
                return new int[2] { firstNumIndex, complements[neededNumber] };
            }
            else
            {
                complements[currentNumber] = firstNumIndex;
            }
        }

        return new int[2];
    }
}