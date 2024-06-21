namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays{
    public  static bool IsRotatedSorted(int[] nums)
    {
        if (nums.Length == 1)
            return true;
        var isSorted = true;
        int count = 0;
        int currentIndex = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if(nums[i]<nums[i-1])
                count++;
         
        }
        if( nums[nums.Length -1 ] > nums[0])
            count++;
        return count<=1;
    }
    
}