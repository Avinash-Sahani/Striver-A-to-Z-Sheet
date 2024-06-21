namespace Striver_DSA_A_Z._02_Arrays._03_Hard;

public partial class Arrays
{
    public static int MaxProduct(int[] nums) {
        double max = double.MinValue;
        double prefix =1;
        double suffix=1;
        int n = nums.Length ;
        int p1 =0;
        int p2= n - 1;

        while(p1<n)
        {
            var num  = nums[p1];
            prefix *= (double)num;
            if(prefix>max )
            {
                max = prefix;
            }

            if(num==0)
                prefix=1;

            p1++;


        }
        while(p2>=0)
        {
            var num  = nums[p2];
            suffix *= (double)num;
            if(suffix>max )
            {
                max = suffix;
            }




            if(num==0)
                suffix = 1;
            p2--;


        }
        return (int)max;



    }
}