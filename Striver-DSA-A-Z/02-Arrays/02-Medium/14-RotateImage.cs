namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        int m = matrix[0].Length;

        for(int i=0; i<n; i++)
        {
            for(int j=i+1; j<m; j++)
            {
                (matrix[i][j],matrix[j][i]) = (matrix[j][i],matrix[i][j]);
            }
        }
        for(int i=0;i<n;i++)
        {
            int k=m-1;
            int j=0;
            while(j<=k)
            {
                (matrix[i][j],matrix[i][k]) = (matrix[i][k],matrix[i][j]);
                j++;
                k--;
            }

        }

    }
}