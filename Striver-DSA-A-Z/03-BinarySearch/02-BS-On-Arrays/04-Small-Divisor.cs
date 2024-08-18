namespace Striver_DSA_A_Z._03_BinarySearch.BS_On_Arrays;

public partial class BinarySearch{
    public int smallDivisor(int[] nums, int num)
    {
        double sum=0;

        for(int i=0; i<nums.Length; i++)
            sum += Math.Ceiling((double)nums[i] / (double) num);

        return (int) sum;
    }

    public int SmallestDivisor(int[] nums, int threshold) {


        int low =1;
        int max = int.MinValue;

        for(int i=0; i<nums.Length; i++)
            max = Math.Max(max,nums[i]);

        int high  = max;
        int mid =0;

        while(low<=high)
        {

            mid = (low+high)/2;

            int sum = smallDivisor(nums,mid);

            if(sum>threshold)
                low = mid+1;
            else
            {

                high = mid-1;

            }

        }
        return low;
    }
}