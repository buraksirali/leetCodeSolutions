public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var result = new List<int>();

        for(int j = 0; j < nums2.Length; j++)
        {
            for(int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] == nums2[j])
                {
                    result.Add(nums1[i]);
                    nums2[j] = -2;
                    nums1[i] = -1;
                }
            }
        }

        return result.ToArray();
    }
}