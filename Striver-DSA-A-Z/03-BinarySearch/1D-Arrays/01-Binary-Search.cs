namespace Striver_DSA_A_Z._03_BinarySearch;
public partial class BinarySearch
{
    public int BinarySearchNum(int [] nums,int low,int high,int target)
    {

        if(low>high)
            return -1;

        int mid = (low + high)/2;

        if(nums[mid] == target)
            return mid;
        else if(nums[mid]<target)
            return BinarySearchNum(nums,mid+1,high,target);
        else
            return BinarySearchNum(nums,low,mid-1,target);
    }

    public int Search(int[] nums, int target) {

        return BinarySearchNum(nums,0,nums.Length-1,target);
    }

}