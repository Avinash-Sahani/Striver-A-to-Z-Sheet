namespace Striver_DSA_A_Z._02_Arrays.Easy;

public partial class Arrays
{
    public static int RemoveDuplicates(int[] nums)
    {
        int duplicatePointer = 0;
        
        int n = nums.Length;
        if(duplicatePointer >= n) 
            return duplicatePointer;
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