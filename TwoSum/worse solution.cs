public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int firstNumIndex = 0; firstNumIndex < nums.Length; firstNumIndex++) {
            var firstNum = nums[firstNumIndex];
            var numToSearch = target - firstNum;

            for (int secondNumIndex = firstNumIndex + 1; secondNumIndex < nums.Length; secondNumIndex++) {
                if (nums[secondNumIndex] == numToSearch)
                    return new int[] { firstNumIndex, secondNumIndex };
            }
        }

        return new int[2];
    }
}