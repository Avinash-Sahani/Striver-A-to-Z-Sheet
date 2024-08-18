namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays
{
    public  int longestSubarrayWithSumK(int []a, long k) {

    

        int left = 0;
        int right = 1;
        long sum = a[0];
        int n = a.Length;
        int maxLength = -1;
        while(right<n)
        {


            while(sum >k && left<right )
            { 
                sum -= a[left];
                left++;
            }

        
            
            if(sum==k)
            {

                int length = (right - left) ; 
                maxLength = Math.Max(length, maxLength);
                    
            }
            
            if(right<n)
                sum+= a[right];
            
            right++;





        }





        return maxLength;

       


      
    }
}