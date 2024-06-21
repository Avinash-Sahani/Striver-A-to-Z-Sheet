namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int element = -1;
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            if (count == 0)
            {
                element = nums[i];
            }

            if (nums[i] == element)
            {
                count++;
            }
            else
                count--;
        }

        return element;
    }
}