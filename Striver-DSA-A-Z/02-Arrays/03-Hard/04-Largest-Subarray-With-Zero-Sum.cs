namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays
{
    public int maxLen(int[] arr, int n)
    {


        int length=0;
        int maxLen = 0;
        int sum=0;
        Dictionary<int,int> prefix = new Dictionary<int,int>();
        for(int i=0; i<n; i++)
        {

            sum+=arr[i];
            if(sum==0)
            {
                length = i+1;
                maxLen = Math.Max(length,maxLen);
            }
            else
            {

                if(prefix.TryGetValue(sum,out int index))
                    maxLen = Math.Max(maxLen,i-index);

                prefix.TryAdd(sum,i);
            }

        }
        return maxLen;

    }

}