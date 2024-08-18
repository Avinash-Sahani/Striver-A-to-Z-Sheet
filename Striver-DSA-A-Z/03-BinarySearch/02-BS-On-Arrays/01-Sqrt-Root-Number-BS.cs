namespace Striver_DSA_A_Z._03_BinarySearch.BS_On_Arrays;

public  partial class BinarySearch {

    public long floorSqrt(long x)
    {

        if(x == 1)
            return x;


        long low = 1;
        long high =(long) Math.Floor((decimal)(x/2));
        long max = 0;
        while(low<=high)
        {

            decimal m  = low + (high-low)/2;
            long mid = (long) Math.Floor(m);
            var value = mid*mid;
            if((value)<=x)
            {

                max = mid;

                low = mid+1;
            }

            else
                high = mid-1;


        }
        return max;
        //Your code here
    }
}