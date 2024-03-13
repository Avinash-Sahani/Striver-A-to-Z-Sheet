namespace Striver_DSA_A_Z._02_Arrays.Easy;

public partial class Arrays
{
    public static int LargestElement(int[] arr, int n)
    {
        int largest = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > largest)
                largest = arr[i];
        }
        return largest;
    }
    
}