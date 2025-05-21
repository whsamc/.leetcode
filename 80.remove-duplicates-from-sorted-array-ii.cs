/*
 * @lc app=leetcode id=80 lang=csharp
 *
 * [80] Remove Duplicates from Sorted Array II
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
         // To count the unique values and check for one duplicate
        Dictionary<int, int> numsDict = new Dictionary<int, int>();

        // How many times to move this element backwards to fill in the gap
        int backtrack = 0;

        // How many elements are in the final array
        int elementCount = 0;

        for(int i = 0; i < nums.Length; i++){
            // Try to add to the dictionary first, failing if it exists
            if(numsDict.TryAdd(nums[i], 1)){
                // Added to dictionary

                // Place element in the appropriate place: this position minus backtrack value
                nums[i - backtrack] = nums[i];

                // Increase element count
                elementCount++;
            }
            // Check if it has been seen only once
            else if(numsDict[nums[i]] == 1){
                // Increase the value of that particular key
                numsDict[nums[i]]++;

                // Place element in position minus backtrack value
                nums[i - backtrack] = nums[i];

                // Increase element count
                elementCount++;
            }
            // Else the key has been seen twice or more
            else{
                backtrack++;
            }
        }

        return elementCount;
    }
}
// @lc code=end

