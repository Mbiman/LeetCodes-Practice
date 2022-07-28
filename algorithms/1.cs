public class Solution {
    public int Search(int[] nums, int target) {
        int start, end, middle;
        start = 0;
        end = nums.Length - 1;
        
        while(start <= end){
            middle = (start + end) / 2;
            
            if(nums[middle] == target){
                return middle;
            }else if(nums[middle] < target){
                start = middle + 1;
            }else{
                end = middle - 1;
            }
        }
        return -1;
    }
}