using Math = System.Math;

namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays{

    public  void Rotate(int[] nums, int k)
    {

        int n =nums.Length;
        if(k>n)
            k = k %n;

        int j = n-k;
        var endIndex = nums.Length-1;
        ReverseArray(nums,0,j-1);
        ReverseArray(nums,j,endIndex);
        ReverseArray(nums, 0, endIndex);

    }

    public  void ReverseArray(int[] nums, int startIndex, int endIndex)
    {

        while (startIndex < endIndex)
        {
            (nums[startIndex], nums[endIndex]) = (nums[endIndex], nums[startIndex]);
            startIndex++;
            endIndex--;
        }
    }

}
