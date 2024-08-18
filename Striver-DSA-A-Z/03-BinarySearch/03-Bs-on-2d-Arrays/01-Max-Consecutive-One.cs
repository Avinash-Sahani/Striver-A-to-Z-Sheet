namespace Striver_DSA_A_Z._03_BinarySearch._03_Bs_on_2d_Arrays;

public partial class BinarySearch
{
    int RowWithMax1s(int[,] arr, int n, int m)
    {
        int maxRow = -1;
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            int low = 0;
            int high = m - 1;

            int index = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[i, mid] == 0)
                {
                    index = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            int totalOnes = (index == -1) ? m : (m - index) - 1;

            if (totalOnes > max)
            {
                max = totalOnes;
                maxRow = i;
            }
        }

        return maxRow;
    }
}