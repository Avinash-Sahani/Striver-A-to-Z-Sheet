namespace Striver_DSA_A_Z._01_Sorting.Sorting_I;

public partial class SortingAlgo
{
    public static void InsertionSort(int[] arr, int n)
    {
        for (var i = 1; i < n; i++)
        {
            int j = i;
            while (j > 0 && arr[j] < arr[j - 1])
            {
                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                j--;
            }
        }
    }
}
