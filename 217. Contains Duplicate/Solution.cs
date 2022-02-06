/*
    1. Iterate over the array and check if the set contains a number. return true if it contains the number in otherwise return false
    
    Time Complexity: O(n);
    Space Complexity: O(n):
*/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums == null || nums.Length == 0) return false;
        
        HashSet<int> hSet = new();
        
        foreach(int num in nums) {
            if(hSet.Contains(num)) {
                return true;
            }
            hSet.Add(num);            
        }
        return false;
    }
}