



using Striver_DSA_A_Z._01_Sorting;

int[] arr = { 64, 25, 12, 22, 11 };
SortingAlgo.quickSort(arr,0,arr.Length-1);
Console.WriteLine("Sorted array:");
foreach (int num in arr)
{
    Console.Write(num + " ");
}