/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {

        // 2 pointers for each side of the string
        int leftPointer = 0;
        int rightPointer = s.Length - 1;

        // Loop until the pointers meet each other
        while(leftPointer <= rightPointer){

            // Move both pointers inwards at the same time, unless the char is not a
            // letter or digit

            // Move the leftpointer right unless it is a digit or letter
            while(leftPointer < rightPointer && !char.IsLetterOrDigit(s[leftPointer])){
                leftPointer++;
            }
            // Move the rightpointer left unless it is a digit or letter
            while(leftPointer < rightPointer && !char.IsLetterOrDigit(s[rightPointer])){
                rightPointer--;
            }

            // Lowercase the chars and compare them and return false if they are not the same
            if(char.ToLower(s[leftPointer]) != char.ToLower(s[rightPointer])){
                return false;
            }
            // If they are the same, move both pointers inward.
            else{
                leftPointer++;
                rightPointer--;
            }
        }
        
        // All good
        return true;
        
    }
}
// @lc code=end

