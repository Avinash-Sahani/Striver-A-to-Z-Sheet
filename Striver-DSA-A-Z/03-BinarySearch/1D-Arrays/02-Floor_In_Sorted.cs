namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch{


    public  int Bsfloor(long []arr,int low,int high,long x)
    {

        int ans  = -1;

        while(low<=high)
        {
            int mid = (low + high)/2;
            if(arr[mid]<=x)
            {
                if(mid>ans)
                    ans = mid;


                low = mid+1;

            }
            else
            {
                high = mid-1;
            }
        }
        return ans;


    }
    public  int findFloor(long []arr, int n, long x)
    {


        return Bsfloor(arr,0,n-1,x);

    }
}