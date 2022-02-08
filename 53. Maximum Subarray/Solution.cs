/*
    Best Solution
    So this is a tricky one (use Kadane's Algorithm)
    1. Initialize 2 variables currentSubArray and maxSubArrry as the first element in the list.
    2. Iterate over the length of array starting from 1.
        compute the currentSubArray by taking Max of CurrentSubArray + nums[i] or nums[i] which is like starting over and using nums[i] as starting point. Computer maxSubArray by taking max or currentSubArray and maxSubArray and then return maxSubArray.
    
    Time Complexity: O(n)
    Space Complexity: O(1)
*/

public class Solution {    
    public int MaxSubArray(int[] nums) {
        int currentSubArray = nums[0];
        int maxSubArray = nums[0];
        
        for(int i = 1; i < nums.Length; i++) {
            currentSubArray = Math.Max(currentSubArray + nums[i], nums[i]);
            maxSubArray = Math.Max(currentSubArray, maxSubArray);
        }
        
        return maxSubArray;
    }
    
    
    /*
        Iterate over the list and compute the currentSubArray by adding the current item to the currentSubArray. 
        Find the Max of SubArray and CurrentSubArray and assign it to maxsubarray. Do this for every element in the list
        
        Time Complexity: O(n^2)
        Space Complexity: O(1)
    */
    public int MaxSubArrayBruteForce(int[] nums) {
        int maxSubArray = 0;
        
        for(int i = 0; i < nums.Length; i++) {
            int currentSubArray = 0;
            for(int j = i; j < nums.Length; j++) {
                currentSubArray += nums[j];
                maxSubArray = Math.Max(maxSubArray, currentSubArray);
            }
        }
        
        return maxSubArray;
    }
}