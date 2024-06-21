using Math = System.Math;

namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays{
    
    public static void Rotate(int[] nums, int k)
    {
        
        if(nums.Length ==1)
            return ;
        var j = nums.Length - k;
        if(j<0)
        {
           decimal val = j / nums.Length;
            int totalIterations =(int) Math.Floor(val);
            int totalSum = totalIterations * nums.Length;
            j+=totalSum;
        }
        
        var endIndex = nums.Length-1;
        ReverseArray(nums,0,j-1);
        ReverseArray(nums,j,endIndex);
        ReverseArray(nums, 0, endIndex);

    }

    public static void ReverseArray(int[] nums, int startIndex, int endIndex)
    {

        while (startIndex < endIndex)
        {
            (nums[startIndex], nums[endIndex]) = (nums[endIndex], nums[startIndex]);
            startIndex++;
            endIndex--;
        }
    }
    
}
