namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch {

     int floor = -1;
     int ceil = -1;
    public  int[] BsfloorCeil(int[]arr,int low,int high,int x)
    {


        if(low>high)
        {
            if(floor==-1)
                ceil=arr[0];
            return new int[]{floor, ceil};

        }


        int mid = (low + high) /2;
        if(x == arr[mid])
            return new int[] {arr[mid],arr[mid]};

        if(arr[mid]<=x)
        {
            if(arr[mid]>floor)
            {
                floor= arr[mid];
                if((mid+1) <arr.Length)
                    if(arr[mid+1]>=x)
                        ceil = arr[mid+1];

            }
            return BsfloorCeil(arr,mid+1,high,x);
        }
        else
        {

            return BsfloorCeil(arr,low,mid-1,x);
        }



    }
    public  int[] getFloorAndCeil(int[] a, int n, int x) {

        return BsfloorCeil(a,0,n-1,x);
        // Wriute your code here.
    }
}