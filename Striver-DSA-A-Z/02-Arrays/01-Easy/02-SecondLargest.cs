namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays
{
    public  int[] GetSecondOrderElements(int n, int[] a) {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int num in a)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num != largest && num > secondLargest)
            {
                secondLargest = num;
            }

            if (num < smallest)
            {
                secondSmallest = smallest;
                smallest = num;
            }
            else if (num != smallest && num < secondSmallest)
            {
                secondSmallest = num;
            }
            
        }

        int[] result = { secondLargest, secondSmallest };
        return result;
    }
}