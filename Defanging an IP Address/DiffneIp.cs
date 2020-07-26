public class Solution {
    public string DefangIPaddr(string address) {
        String sb = "";

        int i;
        for(i=0 ; i<address.Length;i++)
        {
            if(address[i].Equals('.'))
                sb+="[.]";
            else sb+=address[i];
        }
      
        return sb;
        
    }
}