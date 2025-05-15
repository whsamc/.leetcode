/*
 * @lc app=leetcode id=392 lang=csharp
 *
 * [392] Is Subsequence
 */

// @lc code=start
public class Solution {
    public bool IsSubsequence(string s, string t) {
                
        if(s.Length == 0){
            return true;
        }

        // Pointer for subsequence s
        int pointer = 0;

        // Iterate through string t
        foreach(var x in t){

            // Check if the subsquence fits
            if(x == s[pointer]){
                pointer++;
            }
            // If the pointer amount is equal to the length of the subsequence
            if(pointer == s.Length){
                return true;
            }
        }

        return false;
    }
}
// @lc code=end

