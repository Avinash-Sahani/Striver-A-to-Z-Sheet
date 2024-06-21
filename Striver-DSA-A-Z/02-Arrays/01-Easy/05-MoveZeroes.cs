namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays {

    public void MoveZeroes(int[] nums) {
        
        if(nums.Length == 1)
            return;
        int p1 = 0;
        int p2 = 1;
        while(p2<nums.Length)
        {
           
            if(nums[p1]==0 && nums[p2]!=0)
            {
                (nums[p1],nums[p2]) = (nums[p2],nums[p1]);
                p1++;
                p2++;
            }
            else if(nums[p1] ==0 && nums[p2] ==0)
            {
                p2++;
            }
            else{
                p1++;
                p2++;
            }

        }
    }
    
}