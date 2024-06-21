namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays
{
    public IList<int> MajorityElementII(int[] nums)
    {

        int count_1 = 0, count_2 = 0;
        IList<int> majority = new List<int>();
        int num1 = int.MinValue, num2 = int.MinValue;
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {

            if (count_1 == 0 && nums[i] != num2)
                num1 = nums[i];

            if (count_2 == 0 && nums[i] != num1)
                num2 = nums[i];


            if (nums[i] == num1)
                count_1++;


            else if (nums[i] == num2)
                count_2++;

            else
            {
                count_1--;
                count_2--;
            }



        }

        decimal divVal = n / 3;
        decimal n_3 = Math.Floor(divVal);
        n_3 = (int)n_3;
        n_3++;
        count_1 = 0;
        count_2 = 0;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] == num1)
                count_1++;

            if (nums[i] == num2)
                count_2++;

        }

        if (count_1 >= n_3)
            majority.Add(num1);
        if (count_2 >= n_3)
            majority.Add(num2);



        return majority;



    }
}
