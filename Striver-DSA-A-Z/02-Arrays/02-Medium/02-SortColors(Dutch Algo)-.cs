namespace Striver_DSA_A_Z._02_Arrays;
//Link : https://leetcode.com/problems/sort-colors/
public partial class Arrays {
    public void SortColors(int[] nums) {

        int n = nums.Length;
        int low =0,high =n-1 ,mid =0;


        while(mid<=high)
        {

            if(nums[mid] ==0)
            {

                (nums[low],nums[mid]) = (nums[mid],nums[low]);
                low++;
                mid++;
            }
            else if(nums[mid] ==1)
                mid++;

            else if(nums[mid]==2)
            {

                (nums[mid],nums[high]) = (nums[high],nums[mid]);
                high--;
            }




        }

    }
}