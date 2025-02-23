public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var occurrence = new Dictionary<int, bool>();
        foreach (var num in nums)
        {
            if (occurrence.ContainsKey(num))
                return true;
            
            occurrence[num] = true;
        }
        return false;
    }
}