namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch {

    public  int Bsfloor(int []arr,int low,int high,int x)
    {
        int ans = -1;
        while(low<=high)
        {
            int mid = (low + high)/2;
            if(arr[mid]==x)
                return mid;
            else if(arr[mid]<x)
            {
                if(mid>ans)
                    ans = mid;
                low = mid+1;

            }
            else
                high = mid-1;
        }
        return ans+1;


    }
    public int SearchInsert(int[] nums, int target) {
        return Bsfloor(nums,0,nums.Length-1,target);
    }

}