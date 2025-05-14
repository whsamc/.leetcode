/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        
        // Hashmap for roman numerals to numbers
        Dictionary<char, int> romanNumerals = new Dictionary<char, int>();

        // Entries for every roman numeral
        romanNumerals.Add('I', 1);
        romanNumerals.Add('V', 5);
        romanNumerals.Add('X', 10);
        romanNumerals.Add('L', 50);
        romanNumerals.Add('C', 100);
        romanNumerals.Add('D', 500);
        romanNumerals.Add('M', 1000);
        
        // Pointer for the previous character in the string
        int previousNumber = 0;

        // Total output of the roman numerals
        int totalNumber = 0;

        foreach(char i in s){
            int currentNum = 0;
            romanNumerals.TryGetValue(i, out currentNum);

            // If the current char is greater than the previous
            if(currentNum > previousNumber){
                // Subtract the previous char times 2 from the total
                totalNumber -= previousNumber * 2;
            }

            totalNumber += currentNum;

            previousNumber = currentNum;
        }

        return totalNumber;
    }
}
// @lc code=end

