public class Solution {
    public int NumIdenticalPairs(int[] nums) {
            int i = 0 , j = 0 ,  pair=0 ; 
        for(i=0 ; i<nums.Length;i++){
            for(j=1; j<nums.Length;j++){
                if(nums[i]==nums[j]&&i<j)
                    pair+=1;
                
                
            }
            
            
            
            
            
        }
        return pair ;
    }
}