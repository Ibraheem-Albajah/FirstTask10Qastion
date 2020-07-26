public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] res = new int[nums.Length];
        for(int i =0 ;i<nums.Length; i++){
                            int counter =0;

            for(int j =0 ; j<nums.Length ; j++){
          if(i==j){}else{
              if(nums[j]<nums[i])
                  counter++;
              
              
              
          }
            }
        res[i]=counter;
        }
        return res;
    }
}