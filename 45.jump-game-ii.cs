/*
 * @lc app=leetcode id=45 lang=csharp
 *
 * [45] Jump Game II
 */

// @lc code=start
public class Solution {
    public int Jump(int[] nums) {
        
        // local variables
        int jumps = 0;
        int highestJump = 0;
        int lastChanceToJump = 0;

        // Iterate through the length of the array
        for(int i = 0; i < nums.Length - 1; i++){
            // Determine if the highest jump possible is possible from this position or before
            highestJump = Math.Max(highestJump, i + nums[i]);

            // Determine if the current index is at the end
            if(i == lastChanceToJump){
                // Increase the hops because one must hop at this point
                jumps++;
                // Update the last index to jump with the highest jump available
                lastChanceToJump = highestJump;
            }
        }

        return jumps;
    }
}
// @lc code=end

