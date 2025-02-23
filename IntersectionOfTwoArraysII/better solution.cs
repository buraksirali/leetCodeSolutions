public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        IDictionary<int, int> mapCounter;

        if (nums1.Length > nums2.Length)
        {
            mapCounter = GetMapCounter(nums2);
            return IntersectWithCounter(mapCounter, nums1);
        }
        mapCounter = GetMapCounter(nums1);
        
        return IntersectWithCounter(mapCounter, nums2);
        
    }

    public IDictionary<int, int> GetMapCounter(IEnumerable<int> nums)
    {
        Dictionary<int, int> mapCounter = new();
        foreach(int num in nums)
        {
            if (mapCounter.ContainsKey(num))
            {
                mapCounter[num]++;
            }
            else
            {
                mapCounter[num] = 1;
            }
        }

        return mapCounter;
    }
    
    public int[] IntersectWithCounter(IDictionary<int, int> mapCounter, IEnumerable<int> nums)
    {
        var result = new List<int>();

        foreach(int num in nums)
        {
            if (mapCounter.ContainsKey(num) && mapCounter[num] > 0)
            {
                result.Add(num);
                mapCounter[num]--;
            }
        }

        return result.ToArray();
    }
}