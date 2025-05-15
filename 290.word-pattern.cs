/*
 * @lc app=leetcode id=290 lang=csharp
 *
 * [290] Word Pattern
 */

// @lc code=start
public class Solution {
    public bool WordPattern(string pattern, string s) {
        // Create a dictionary to check for existence of unique binding
        Dictionary<char, string> checkDict = new Dictionary<char, string>();

        // Split the string into a string of arrays
        string[] stringArray = s.Split(' ');

        // First check if the length of the pattern and string are the same
        if(pattern.Length != stringArray.Length){
            return false;
        }

        // Iterate through the loop
        for(int i = 0; i < pattern.Length; i++){
            // Check if the dictionary contains the key and if the value is equal to the current array index
            if(checkDict.ContainsKey(pattern[i])){
                if(checkDict[pattern[i]] != stringArray[i]){
                    return false;
                }
            }
            // Check if the value from the string already exists and matches with current index
            else if(checkDict.ContainsValue(stringArray[i])){
                return false;
            }
            // If it doesn't exist, add the entry
            else{
                checkDict.TryAdd(pattern[i], stringArray[i]);
            }

        }

        return true;
    }
}
// @lc code=end

