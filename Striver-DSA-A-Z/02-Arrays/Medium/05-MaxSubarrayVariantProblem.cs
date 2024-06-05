namespace Striver_DSA_A_Z._02_Arrays.Medium;

public partial class Arrays {
    public long pairWithMaxSum(long[] arr, long N)
    {
        long ans = 0;

       
        for(int i=1; i<N; i++)
        {
            long sum = arr[i] + arr[i-1];
            
            ans = Math.Max(sum, ans);
        }
                 
   
        return ans;
    }
}