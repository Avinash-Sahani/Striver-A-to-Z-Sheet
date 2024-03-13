namespace Striver_DSA_A_Z._02_Arrays.Easy;

public partial class Arrays
{
    public static int[] GetSecondOrderElements(int n, int[] a) {
        int largest = int.MinValue;
        int secondlargest = int.MinValue;
        int smallest = int.MaxValue;
        int secondsmallest = int.MaxValue;

        for (int i = 0; i < n; i++) {
            if (a[i] > largest) {
                secondlargest = largest;
                largest = a[i];
            }
            if (a[i] < smallest) {
                secondsmallest = smallest;
                smallest = a[i];
            }
        }
        
        int[] arr = { secondlargest, secondsmallest };
        return arr;
    }
}