/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        // Create a dictionary with letters from magazine and number of times available
        Dictionary<char, int> magazineDict = new Dictionary<char, int>();

        // Iterate through magazine
        foreach(var x in magazine){
            // Try adding to dictionary. It won't overwrite if it already exists
            if(!magazineDict.TryAdd(x, 1)){
                // If it exists already, update its value by adding 1
                magazineDict[x] += 1;
            }
        }

        // Iterate through ransomnote
        foreach(var x in ransomNote){
            // Check if the key exists with a value greater than 1
            if(magazineDict.TryGetValue(x, out int y) && y > 0){
                // Reduce count by 1
                magazineDict[x] -= 1;
            }
            // If not exist, return false
            else{
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

