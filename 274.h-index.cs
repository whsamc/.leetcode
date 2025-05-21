/*
 * @lc app=leetcode id=274 lang=csharp
 *
 * [274] H-Index
 */

// @lc code=start
public class Solution {
    public int HIndex(int[] citations) {
        
        // The current amount of citations. Make it max because it will be 
        int count = 0;

        // Sort the array to count the number of citations and get the number of citations needed
        Array.Sort(citations);

        // Iterate through the array backwards  
        for(int i = citations.Length - 1; i >= 0; i--){
            if(citations[i] > count){
                count++;
            }
            else{
                return count;
            }
        }

        return count;
    }
}
// @lc code=end

