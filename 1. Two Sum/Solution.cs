/*
    1. Initialize Dictionary where DictinoaryKey is value at i and DictionaryValue is i or index itself
    2. Iterate over nums array and add the value and index to the dictionary
        compute the complement meaning complement = target - nums[i]
        if Dictionary contains of complement then we've seen this number before we can return an array of the indices
        
    Time Complexity: O(n)
    Space Complexity: O(n)
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length < 2) return null;
        
        Dictionary<int, int> map = new();
        
        for(int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if(map.ContainsKey(complement)) {
                return new int[] {map[complement], i};
            } 
            if(!map.ContainsKey(nums[i])) {
               map.Add(nums[i], i); 
            }            
        }    
        return null;
    }
}