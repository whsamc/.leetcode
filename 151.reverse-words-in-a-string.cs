/*
 * @lc app=leetcode id=151 lang=csharp
 *
 * [151] Reverse Words in a String
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        // 2 dictionaries to map chars from both strings to each other
        Dictionary<char, char> dict1 = new Dictionary<char, char>();

        // Iterate through the length of the first string
        for(int i = 0; i < s.Length; i++){
            
            // Check if first dictionary contains char
            if(dict1.ContainsKey(s[i])){
                // Check if the entry is equal to the current value
                if(dict1[s[i]] != t[i]){
                    return false;
                }
            }
            // Check if the other char already exists within the dict as a value
            else if(dict1.ContainsValue(t[i])){
                return false;
            }

            // Try to add the entry to the dictionary
            else{
                dict1.TryAdd(s[i], t[i]);
            }
        }

        return true;
    }
}
// @lc code=end

