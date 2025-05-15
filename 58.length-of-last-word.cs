/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        // Count the length of the last word
        int lastWordLength = 0;

        // Trim the whitespaces from the end
        s = s.Trim();

        // Iterate backwards through the string
        for(int i = s.Length - 1; i >= 0; i--){

            // Check if the character is whitespace and increase count if it isn't
            if(!Char.IsWhiteSpace(s[i])){
                lastWordLength++;
            }
            // Return the length upon finding first whitespace
            else{
                return lastWordLength;
            }
        }
        // Return length upon finishing loop
        return lastWordLength;
    }
}
// @lc code=end

