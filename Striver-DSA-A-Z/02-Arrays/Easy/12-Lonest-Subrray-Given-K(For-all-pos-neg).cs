namespace Striver_DSA_A_Z._02_Arrays.Easy;
//Problem Link : https://www.geeksforgeeks.org/problems/longest-sub-array-with-sum-k0809/1?utm_source=youtube&utm_medium=collab_striver_ytdescription&utm_campaign=longest-sub-array-with-sum-k
public partial class Arrays
{
    public int lenOfLongSubarr(int[] A, int N, int K)
    {

        int maxLength = 0;
        Dictionary<int, int> sums = new Dictionary<int, int>();
        int sum = 0;
        int length = 0;
        for (int i = 0; i < N; i++)
        {
            sum += A[i];
            if (sum == K)
            {
                length = i + 1;
                maxLength = Math.Max(length, maxLength);
            }

            int reverseSum = sum - K;

            if (sums.TryGetValue(reverseSum, out int index))
            {
                length = i - index;
                maxLength = Math.Max(length, maxLength);
                
            }

            sums.TryAdd(sum, i);


        }
        
        

        return maxLength;
    }
}