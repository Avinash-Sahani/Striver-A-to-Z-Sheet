namespace Striver_DSA_A_Z._01_Sorting;

public partial  class  SortingAlgo
{
    public  void quickSort(int[] input, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {

            int partitionIndex = GetPartitionIndex(input, startIndex, endIndex);
            quickSort(input,startIndex,partitionIndex-1);
            quickSort(input,partitionIndex+1,endIndex);

        }
    }

    public  int GetPartitionIndex(int[] arr, int startIndex, int endIndex)
    {

        int low = startIndex;
        int high = endIndex;
        int pivot = arr[low];
        int i = low+1;
        int j = high;
        while (i<=j)
        {
            while (  i <=high && arr[i] <= pivot )
            {
                i++;
            }
        
            while (j>=low+1 && arr[j] >= pivot )
            {
                j--;
            }
            if(i<j)
             (arr[i], arr[j]) = (arr[j], arr[i]);
        }
        (arr[low], arr[j]) = (arr[j], arr[low]);
        return j;
      
    }
}