



using Striver_DSA_A_Z._01_Sorting;
using Striver_DSA_A_Z._02_Arrays.Easy;

int[] arr = { 0,0,1,1,1,2,2,3,3,4 };
Arrays.RemoveDuplicates(arr);
//Console.WriteLine("Sorted array:");
foreach (int num in arr)
{
    Console.Write(num + " ");
}