namespace Striver_DSA_A_Z._03_BinarySearch._03_Bs_on_2d_Arrays;

public partial class BinarySearch
{
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length;
        int m  = matrix[0].Length;
        bool isExists = false;
        for(int i=0; i<n; i++)
        {
            if(isExists)
                break;
            int low = 0;
            int high  = m-1;

            if(!(target>=matrix[i][low] && target<=matrix[i][high]))
                continue;
            while(low<=high)
            {

                int mid = (low +high)/2;
                if(matrix[i][mid]==target)
                {
                    isExists = true;
                    break;
                }
                else if(matrix[i][mid]>target)
                    high = mid-1;
                else
                    low = mid+1;
            }


        }
        return isExists;
    }
}