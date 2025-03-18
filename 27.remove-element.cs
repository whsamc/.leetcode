/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        // number not equal to val
        int k = 0;

        // number equal to val
        int l = 0;

        // Pointer to first index equal to val
        int m = 0;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                k++;
                if(m >= 0){
                    nums[i - m] = nums[i];
                }
            }
            else{
                l++;
                nums[i] = 0;
                m++;
            }

        }

        return k;

    }
}
// @lc code=end

