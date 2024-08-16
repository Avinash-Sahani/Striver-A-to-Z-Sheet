namespace Striver_DSA_A_Z._03_BinarySearch.BS_On_Arrays;

public partial class BinarySearch {
    public int NthRoot(int n, int m)
    {


        if(m==1 || n==1)
            return m;

        int low = 1;
        int high = m -1;
        int ans = -1;
        while(low<=high)
        {

            int mid = low + (high-low)/2;

            long value = 1;
            for(int i=1; i<=n; i++)
            {
                value*=mid;

                if(value > m)
                {
                    high = mid-1;
                    break;

                }


            }

            if(value==m)
            {

                ans = mid;
                break;
            }
            else if(value<m)
                low = mid+1;



        }
        return ans;
    }
}