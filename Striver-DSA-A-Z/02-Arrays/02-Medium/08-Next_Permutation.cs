namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays {
    public void NextPermutation(int[] nums) {

        int n=nums.Length;
        int breakingIndex = -1;
        for(int i=n-2; i>=0; i--)
        {
            if(nums[i]<nums[i+1])

            {
                breakingIndex =i;
                break;
            }

        }
        if(breakingIndex==-1)
        {
            Array.Reverse(nums);
            return;
        }
        for(int i = n-1; i>breakingIndex; i--)
        {
            if(nums[i]>nums[breakingIndex])
            {
                (nums[i],nums[breakingIndex]) = (nums[breakingIndex],nums[i]);
                break;
            }
        }
        Array.Reverse(nums,breakingIndex+1,n-(breakingIndex+1));

    }
}