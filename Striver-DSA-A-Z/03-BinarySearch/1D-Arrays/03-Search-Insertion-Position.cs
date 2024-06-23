namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch {


    public  int Bsfloor(int []arr,int low,int high,int x)
    {

        if(low>high)
            return ans+1;
        int mid = (low + high)/2;
        if(arr[mid]==x)
            return mid;
        else if(arr[mid]<x)
        {
            if(mid>ans)
                ans = mid;
            return Bsfloor(arr,mid+1,high,x);
        }
        else
            return Bsfloor(arr,low,mid-1,x);




    }
    public int SearchInsert(int[] nums, int target) {
        return Bsfloor(nums,0,nums.Length-1,target);
    }

}