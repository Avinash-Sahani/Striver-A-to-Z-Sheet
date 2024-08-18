namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays
{
    public  int RemoveDuplicates(int[] nums)
    {
        int duplicatePointer = 0;
        
        int n = nums.Length;
        if (nums.Length == 1)
            return 1;
        for(int i=1; i<n; i++)
        {
            if(nums[i]!=nums[duplicatePointer] )
            {
                duplicatePointer++;
             
                nums[duplicatePointer] = nums[i]; 
            }
            

        
        }
        return duplicatePointer +1;
    }

    
}