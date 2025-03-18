/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */

// @lc code=start
public class Solution {
    public int SingleNumber(int[] nums) {
        
        // Value to return start with 0, because using XOR
        int value = 0;

        // Iterate through array
        for (int i = 0; i < nums.Length; i++){
            // Using XOR operand will result in the single unique number being the end result
            value = value ^ nums[i];
        }

        return value;
    }
}
// @lc code=end

