namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch {
    public int FindKRotation(List<int> arr) {
        int low = 0;
        int high = arr.Count - 1;
        int min = int.MaxValue;
        int minIndex = 0;

        while (low <= high) {
            int mid = low + (high - low) / 2;

            if (arr[low] <= arr[mid]) {
                if (arr[low] < min) {
                    min = arr[low];
                    minIndex = low;
                }
                low = mid + 1;
            } else {
                if (arr[mid] < min) {
                    min = arr[mid];
                    minIndex = mid;
                }
                high = mid - 1;
            }
        }
        return minIndex;
    }

}