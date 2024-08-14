namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class Arrays
{
    public int SingleNonDuplicate(int[] nums) {
        int n = nums.Length;
        if(n<=1)
            return nums[0];
        else if(nums[0]!=nums[1])
            return nums[0];
        else if(nums[n-1]!=nums[n-2])
            return nums[n-1];


        int low = 1;
        int high = n-2;

        while(low<=high)
        {

            int mid = (low+high)/2;

            if(nums[mid-1]!=nums[mid] && nums[mid+1]!=nums[mid])
                return nums[mid];

            else if((mid%2==0 && nums[mid]==nums[mid+1] || (mid%2!=0 && nums[mid-1]==nums[mid])) )

            {
                low = mid+1;
            }
            else
            {
                high = mid-1;
            }



        }
        return -1;
    }
}