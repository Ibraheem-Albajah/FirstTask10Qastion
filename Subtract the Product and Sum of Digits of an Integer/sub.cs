public class Solution {
    public int SubtractProductAndSum(int n) {
        int sum = 0 , prod = 1  ;
        if(n==0)
            return 0;
        while(n>0){
           int digit=n%10;
            sum+=digit;
            prod*=digit;
            n/=10;
            
            
            
            
        }
        return prod-sum;
    }
}