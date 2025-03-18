/*
 * @lc app=leetcode id=350 lang=csharp
 *
 * [350] Intersection of Two Arrays II
 */

// @lc code=start

using System.Linq;

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        // List for output
        List<int> outputList = new List<int>();

        // Dictionary to store unique elements
        Dictionary<int, int> numsDict = new Dictionary<int, int>();

        // iterate through the 1st array
        for (int i = 0; i < nums1.Length; i++)
        {
            // Try adding the number to the dictionary
            if(!numsDict.TryAdd(nums1[i], 1))
            {
                // If they key already exists, increase the value by 1
                numsDict[nums1[i]] += 1;
            }
        }

        // Iterate throught the 2nd array
        for (int i = 0; i < nums2.Length; i++)
        {
            // Check if the value exists in the dictionary, and if the value is greater than 0
            if(numsDict.ContainsKey(nums2[i]) && numsDict[nums2[i]] > 0)
            {
                // Add it to the output list
                outputList.Add(nums2[i]);

                // Reduce the value of the element in the dictionary
                numsDict[nums2[i]]--;
            }
        }
        
        return outputList.ToArray();
    }


}
// @lc code=end

