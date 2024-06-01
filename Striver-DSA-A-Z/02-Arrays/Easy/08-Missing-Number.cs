namespace Striver_DSA_A_Z._02_Arrays.Easy;

public partial class Arrays {
    public int MissingNumber(int[] nums) {

        int n = nums.Length;
        int sum = ((n+1) * n)/2;
        int arrSum = 0;
        for(int i=0; i<nums.Length; i++)
            arrSum+= nums[i];

        return sum -arrSum;
    }
}