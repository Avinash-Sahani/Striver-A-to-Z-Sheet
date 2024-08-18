namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch
{

    public int GetFirstOccurence(int[] nums, int low, int high, int target)
    {
        int firstOccurence = -1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] == target)
            {
                firstOccurence = mid;
                high = mid - 1;
            }
            else if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return firstOccurence;

    }

    public int GetLastOccurence(int[] nums, int low, int high, int target)
    {
        int lastOccurence = -1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] == target)
            {
                lastOccurence = mid;
                low = mid + 1;
            }
            else if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return lastOccurence;

    }

    public int[] SearchRange(int[] nums, int target)
    {

    int[] numsmatch = new int[2] { -1, -1 };
    int n = nums.Length;
    numsmatch[0] = GetFirstOccurence(nums, 0, n - 1, target);
    numsmatch[1] = GetLastOccurence(nums, 0, n - 1, target);
    return numsmatch;
    }



}