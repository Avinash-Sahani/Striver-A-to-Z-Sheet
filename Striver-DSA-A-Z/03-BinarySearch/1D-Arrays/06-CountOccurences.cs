namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch {


    public int count(int[] arr, int n, int x)
    {

        int first = GetFirstOccurence(arr, 0, n - 1, x);
        int last = GetLastOccurence(arr, 0, n - 1, x);

        if(first==-1 || last==-1)
            return 0;
        return (last-first)+1;

    }


}