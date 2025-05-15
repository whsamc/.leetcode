/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Find the Index of the First Occurrence in a String
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
        int len1 = haystack.Length;
        int len2 = needle.Length;

        // Iterate through the length of haystack minus needle to have enough space for needle
        for(int i = 0; i <= len1 - len2; i++){

            // Check if the index pointer is equal to the first char of needle
            if(haystack[i] == needle[0]){
                
                // Started matching needle
                bool check = true;

                // Iterate through the length of needle
                for(int j = 1; j < len2; j++){

                    // If the next index matches eaches other
                    if(haystack[i+j] != needle[j]){
                        check = false;
                        break;
                    }
                }
                // If it completes the nested loop completely, it matches needle
                if(check){
                    return i;
                }
            }
        }

        // No match
        return -1;
    }
}
// @lc code=end

