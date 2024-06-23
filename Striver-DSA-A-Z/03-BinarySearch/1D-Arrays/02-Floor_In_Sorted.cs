namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch{

    // n is the size of array
    static int ans  = -1;

    public  int Bsfloor(long []arr,int low,int high,long x)
    {

        if(low>high)
            return ans;
        int mid = (low + high)/2;
        if(arr[mid]<=x)
        {
            if(mid>ans)
                ans = mid;


            return Bsfloor(arr,mid+1,high,x);

        }

        return Bsfloor(arr,low,mid-1,x);




    }
    public  int findFloor(long []arr, int n, long x)
    {


        return Bsfloor(arr,0,n-1,x);

    }
}