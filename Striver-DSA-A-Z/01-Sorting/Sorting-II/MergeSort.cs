namespace Striver_DSA_A_Z._01_Sorting;

public partial class SortingAlgo
{
    public  void MergeSort(int []arr , int low ,int high)
    {
        if(low >= high)
            return;
        var mid = (low + high) / 2;
        MergeSort(arr,low,mid);
        MergeSort(arr,mid+1,high);
        MergeArrays(arr,low,mid,high);
        
    }

    private  void MergeArrays(int[] arr, int low, int mid, int high)
    {
        var tempArr = new List<int>();
        var p1 = low;
        var p2 = mid + 1;

        while (p1 <= mid && p2 <= high)
        {
            if (arr[p1] < arr[p2])
            {
                tempArr.Add(arr[p1]);
                p1++;

            }
            else
            {
                tempArr.Add(arr[p2]);
                p2++;
            }
        }
        
        while(p1<=mid)
            tempArr.Add(arr[p1++]);
        while (p2<= high)
            tempArr.Add(arr[p2++]);


        for (int i = low; i <= high; i++)
            arr[i] = tempArr[i - low];
        

    }
}
