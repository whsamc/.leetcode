/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 *
 * https://leetcode.com/problems/longest-common-prefix/description/
 *
 * algorithms
 * Easy (44.45%)
 * Likes:    19107
 * Dislikes: 4720
 * Total Accepted:    4.5M
 * Total Submissions: 9.9M
 * Testcase Example:  '["flower","flow","flight"]'
 *
 * Write a function to find the longest common prefix string amongst an array
 * of strings.
 * 
 * If there is no common prefix, return an empty string "".
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: strs = ["flower","flow","flight"]
 * Output: "fl"
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: strs = ["dog","racecar","car"]
 * Output: ""
 * Explanation: There is no common prefix among the input strings.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= strs.length <= 200
 * 0 <= strs[i].length <= 200
 * strs[i] consists of only lowercase English letters if it is non-empty.
 * 
 * 
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        // Sort the array first so that shortest is first and longest is last
        Array.Sort(strs);

        // Compare the first and last words, because the longest prefix would have to be
        // the length of the shortest word. The longest word needs to be compared to see
        // how long the prefix actually is

        string firstWord = strs.First();
        string lastWord = strs.Last();

        string prefixResult = "";

        // Compare the characters of the first word to the last word
        for(int i = 0; i < firstWord.Length; i++){
            if(firstWord[i] == lastWord[i]){
                prefixResult += firstWord[i];
            }
            else{
                break;
            }
        }

        return prefixResult;

    }
}
// @lc code=end

