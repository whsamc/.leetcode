/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        // Hashset to store unique integers
        HashSet<int> numsSet = new HashSet<int>();
        
        // Iterate through array to detect unique integers
        for (int i = 0; i < nums.Length; i++){

            // Try adding number. If successful, go next.
            if(numsSet.Add(nums[i])){
                // Success
            }
            // If duplicate, return true
            else{
                return true;
            }

        }

        // If every number is unique, return false
        return false;
    }
}
// @lc code=end

