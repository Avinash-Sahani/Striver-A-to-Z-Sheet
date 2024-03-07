using Striver_DSA_A_Z._01_Sorting.Sorting_I;

int[] arr = { 64, 25, 12, 22, 11 };
SortingAlgo.SelectionSort(arr);
Console.WriteLine("Sorted array:");
foreach (int num in arr)
{
    Console.Write(num + " ");
}