public class Solution {
    public int NumIdenticalPairs(int[] nums) {
            int  pair=0 ; 
        for(int i=0 ; i<nums.Length;i++){
            for(int j=1; j<nums.Length;j++){
                if(nums[i]==nums[j]&&i<j)
                    pair+=1;
        }
        return pair ;
    }
}
