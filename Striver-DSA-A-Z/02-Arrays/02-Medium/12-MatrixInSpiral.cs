namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays {
    public  IList<int> SpiralOrder(int[][] matrix) {

        List<int> spiralMatrix = new List<int>();
        int n = matrix.Length;
        int m = matrix[0].Length;
        int left = 0;
        int top = 0;
        int bottom=n-1;
        int right = m-1;

        while(left<=right && top<=bottom)
        {

            for(int i=left; i<=right; i++)
            {
                spiralMatrix.Add(matrix[top][i]);
            }
            top++;
            for(int i=top; i<=bottom; i++)
            {
                spiralMatrix.Add(matrix[i][right]);
            }
            right--;
            if(top<=bottom)
            {
                for(int i=right;  i>=left; i--)
                {
                    spiralMatrix.Add(matrix[bottom][i]);
                }
            }
            bottom--;
            if(left<=right)
            {
                for(int i=bottom; i>=top; i--)
                {
                    spiralMatrix.Add(matrix[i][left]);
                }
            }
            left++;

        }

        return spiralMatrix;
    }
}