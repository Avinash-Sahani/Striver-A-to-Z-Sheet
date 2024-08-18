namespace Striver_DSA_A_Z._03_BinarySearch.BS_On_Arrays;

public partial class BinarySearch {
    public int FindKthPositive(int[] arr, int k) {

        int low = 0;
        int high = arr.Length-1;
        int mid = -1;
        int missing = 0;
        while(low<=high)
        {
            mid = (low+high)/2;
            missing  = arr[mid]-(mid+1);
            if(missing<k)
                low = mid+1;
            else
                high = mid-1;

        }
        return k+high+1;
    }
}