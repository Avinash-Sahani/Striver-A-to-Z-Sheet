
namespace Striver_DSA_A_Z._01_Sorting;

public partial class SortingAlgo
{
    public  void BubbleSort(int[] arr, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < (n - i) - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }
}








