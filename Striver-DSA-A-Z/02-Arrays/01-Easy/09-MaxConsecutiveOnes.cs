namespace Striver_DSA_A_Z._02_Arrays.Easy;
//LeetCode Link : https://leetcode.com/problems/max-consecutive-ones/


public partial class Arrays
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int n = nums.Length;
        int p1 = 0;
        int maxConsecutives = 0;
        int consecutives = 0;
        while (p1 < n)
        {
            if (nums[p1] == 1)
                consecutives++;
            else
            {
                if (consecutives > maxConsecutives)
                {
                    maxConsecutives = consecutives;
                }

                consecutives = 0;
            }


            p1++;
        }

        if (consecutives > maxConsecutives)
        {
            maxConsecutives = consecutives;
        }

        return maxConsecutives;


    }
}