
/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
        // List for output
        List<int> outputList = new List<int>();

        // To specify if need to add next digit
        bool addOne = false;
        bool emptyList = true;
        
        // Iterate backwards from the end
        for (int i = digits.Length - 1; i >= 0; i--)
        {   
            // If first digit in loop
            if(emptyList)
            {
                // If becomes double digit
                if(digits[i] + 1 == 10)
                {
                    // Need to carry the one
                    addOne = true;

                    // Insert 0 into list
                    outputList.Insert(0, 0);
                }
                else
                {
                    // Insert number into list
                    outputList.Insert(0, digits[i] + 1);
                }
                emptyList = false;
            }
            else if(addOne)
            {
                if(digits[i] + 1 == 10)
                {
                    // Need to carry the one
                    addOne = true;

                    // Insert 0 into list
                    outputList.Insert(0, 0);
                }
                else
                {
                    // finished carrying the one
                    addOne = false;

                    // Insert number into list
                    outputList.Insert(0, digits[i] + 1);
                }
            }
            else
            {
                // Insert number into list
                outputList.Insert(0, digits[i]);
            }
        }
        // if still need to carry one
        if(addOne)
        {
            // Insert number into list
            outputList.Insert(0, 1);
        }

        // Output list as array
        return outputList.ToArray();
    }
}
// @lc code=end

