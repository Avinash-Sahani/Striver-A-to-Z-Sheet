namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch
{


    public  int GetCeil(int[] arr, int low, int high, int x)
    {
        if (low > high)
            return ceil;

        int mid = (low + high) / 2;

        if (arr[mid] == x)
        {
            ceil = mid;
            return ceil;
        }
        else if (arr[mid] > x)
        {
            if (ceil == -1)
                ceil = mid;
            else if (mid < ceil)
                ceil = mid;
            return GetCeil(arr, low, mid - 1, x);
        }
        else
        {
            return GetCeil(arr, mid + 1, high, x);
        }
    }

    public int GetFloor(int[] arr, int low, int high, int x)
    {
        if (low > high)
            return floor;

        int mid = (low + high) / 2;

        if (arr[mid] == x)
        {
            floor = mid;
            return floor;
        }
        else if (arr[mid] < x)
        {
            if (mid > floor)
                floor = mid;
            return GetFloor(arr, mid + 1, high, x);
        }
        else
        {
            return GetFloor(arr, low, mid - 1, x);
        }
    }

    public  int[] GetFloorAndCeil(int[] a, int n, int x)
    {
        floor = -1;
        ceil = -1;
        var bs = new BinarySearch();
        bs.GetFloor(a, 0, n - 1, x);
        bs.GetCeil(a, 0, n - 1, x);

        int[] result = { -1, -1 };

        if (floor >= 0)
            result[0] = a[floor];
        if (ceil >= 0)
            result[1] = a[ceil];

        return result;
    }
}