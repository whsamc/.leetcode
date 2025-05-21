/*
 * @lc app=leetcode id=380 lang=csharp
 *
 * [380] Insert Delete GetRandom O(1)
 */

// @lc code=start
public class RandomizedSet {
    
    Random rand = new Random();
    Dictionary<int, int> setDict = new Dictionary<int, int>();
    List<int> setList = new List<int>();
    int count = 0;

    public RandomizedSet() {
        
    }
    
    public bool Insert(int val) {
        // Check if value exists within Dictionary
        if(setDict.TryAdd(val, count)){
            setList.Add(val);
            count++;
            return true;
        }
        else{
            return false;
        }
    }
    
    public bool Remove(int val) {
        // Check if value is in dictionary
        if(setDict.ContainsKey(val)){

            int index = setDict[val];

            // Switch values with end of list to where val currently is(index is saved in dict)
            setList[index] = setList[setList.Count - 1];
            setList[setList.Count - 1] = val;

            // Change index value of swapped key
            setDict[setList[index]] = index;
            setList.RemoveAt(count - 1);

            // Remove the key from the dict
            setDict.Remove(val);
            count--;
            return true;
        }
        else{
            return false;
        }
    }
    
    public int GetRandom() {
        int rndInt = rand.Next(0, count);
        return setList[rndInt];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
// @lc code=end

