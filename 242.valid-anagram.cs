/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        // Return false if the lengths of the strings are different
        if(s.Length != t.Length){
            return false;
        }

        // Sort both strings by turning them into char arrays, sorting, and back to strings
        char[] s1 = s.ToCharArray();
        char[] t1 = t.ToCharArray();
        Array.Sort(s1);
        Array.Sort(t1);

        // Iterate through the string length
        for(int i = 0; i < s1.Length; i++){
            // If the sorted strings are not equal at any point, return false
            if(s1[i] != t1[i]){
                return false;
            }
        }
        
        // Never returned false, so all good
        return true;
    }
}
// @lc code=end

