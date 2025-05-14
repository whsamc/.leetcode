/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) {

        // If on either side of max or min value, return 0
        if(x >= Int32.MaxValue || x <= Int32.MinValue){
            return 0;
        }

        // Check if the integer is negative
        bool isNegative = false;
        if(x > 0){
            isNegative = false;
        }
        else{
            isNegative = true;
        }

        // Convert the integer to string first
        string numString = (Math.Abs(x)).ToString();
        string reversedString = "";

        // Reverse the string
        for(int i = numString.Length - 1; i >= 0; i--){
            reversedString += numString[i];
        }

        // Parse the string into an integer and return based on success. Apply negative if necessary
        if(Int32.TryParse(reversedString, out int reversedInt)){
            if(isNegative){
                return reversedInt* -1;
            }
            else{
                return reversedInt;
            }
        }
        else{
            return 0;
        }
    }
}
// @lc code=end

