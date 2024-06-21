namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays_
{
    public int MaxSubArray(int[] nums)
    {
        int max_sum = int.MinValue;

        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (sum < 0)
                sum = 0;
            sum += nums[i];
            if (sum > max_sum)
                max_sum = sum;
        }

        return max_sum;
    }
}