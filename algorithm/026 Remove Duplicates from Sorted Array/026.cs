public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int length = nums.Length;
        
        if(length == 0)
            return 0;
        
        int i;
        int targetIndex = 1;
        int o = nums[0];
        
        for(i = 1; i < length; i++){
            
            if(nums[i] != o){
                
                o = nums[i];
                nums[targetIndex] = nums[i];
                targetIndex++;
            }
        }
        
        return targetIndex;
    }
}