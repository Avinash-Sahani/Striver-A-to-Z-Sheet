namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch {
    public int FindMin(int[] nums) {
        int low = 0;
        int high = nums.Length -1;
        int min = int.MaxValue;
        while(low<=high)
        {
            int mid = low + (high - low )/2;


            if(nums[low]<=nums[mid])
            {
                min = Math.Min(min,nums[low]);
                low = mid+1;
            }
            else
            {
                min = Math.Min(nums[mid],nums[high]);
                high = mid-1;
            }


        }
        return min;

    }
}