/*
    1. Have two pointers one to keep track of current ZeroIndex and another to keep track of current NonZeroIndex
    2. Iterate over the nums array until NonZeroIndex reachs the end of the array increasing NonZeroIndex by one
        a. Check if the element at NonZeroIndex does not equal to zero then we swap the current ZeroIndex with NonZeroIndex
        
    
    Time Complexity: O(n)
    Space Complexity: O(1)
*/
public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums == null || nums.Length == 0) return;
                
        for(int NonZeroIndex = 0, ZeroIndex = 0; NonZeroIndex < nums.Length; NonZeroIndex++) {
            if(nums[NonZeroIndex] != 0) {
                int temp = nums[NonZeroIndex];
                nums[NonZeroIndex] = nums[ZeroIndex];
                nums[ZeroIndex++] = temp;                
            }
        }
    }
}