/*
    Tricky Question here...
    1. Create 3 seperate arrays one for first 0 to n - 1 products, second 1 to n products (or n to 1 products since going backwards) and last for the answer or result array
    2. Once you have the products of both left and right arrays multiplaying left[i] * right[i] will result in the correct answer in answer[i] and then return answer
    
    Time Complexity: O(n)
    Space Complexity: O(n) (Can be done without using left and right array)
*/


public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        int[] answer = new int[nums.Length];
        
        left[0] = 1;
        right[right.Length - 1] = 1;
        
        for(int i = 1; i < left.Length; i++) {
            left[i] = left[i - 1] * nums[i - 1];
        }
        
        for(int i = right.Length - 2; i >= 0; i--) {
            right[i] = right[i + 1] * nums[i + 1];
        }
        
        for(int i = 0; i < answer.Length; i++) {
            answer[i] = left[i] * right[i];
        }
        
        return answer;
    }
}