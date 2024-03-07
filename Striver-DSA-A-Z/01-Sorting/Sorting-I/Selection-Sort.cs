namespace Striver_DSA_A_Z._01_Sorting.Sorting_I;

public partial class SortingAlgo
{
    public static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
            // Console.Write("pr " + arr[i]); // If you want to print the array elements during sorting
        }
    }
}