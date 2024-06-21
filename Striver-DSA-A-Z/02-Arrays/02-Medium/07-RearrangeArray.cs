namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays {
    public int[] RearrangeArray(int[] nums) {
        int p1=0;
        int p2 =1;
        int n = nums.Length;
        int[] rearrangedarray = new int[n];
      

        for(int i=0;i<n;i++)
        {
            if(nums[i]>=0)
            {
                rearrangedarray[p1] = nums[i];
                p1+=2;
            }
            else
            {
                rearrangedarray[p2] = nums[i];
                p2+=2;
            }
        }
        return rearrangedarray;
    }
}