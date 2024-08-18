namespace Striver_DSA_A_Z._02_Arrays;

public partial class  Arrays
{   public  int SingleNumber(int[] nums)
    {
        int number = 0;
        foreach (var n in nums)
            number = n^number;
        return number;
    }
    
}
