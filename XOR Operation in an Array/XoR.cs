public class Solution {
    public int XorOperation(int n, int start) {
          if(n==0) return 0;
        return XorOperation(n-1, start + 2)^start;
    }
}