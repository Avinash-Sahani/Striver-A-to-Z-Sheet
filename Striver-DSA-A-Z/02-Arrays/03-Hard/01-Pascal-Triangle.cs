namespace Striver_DSA_A_Z._02_Arrays._03_Hard;

public partial class Arrays {
    public int nCr(int n,int r)
    {

        long result= 1;

        if(r>n-r)
            r=n-r;

        for(int i=0; i<r; i++)
        {

            result = result * (n-i);
            result = result/(i+1);
        }
        return (int) result;
    }
    public IList<IList<int>> Generate(int numRows) {

        IList<IList<int>> triangle = new List<IList<int>>();

        for(int i=0; i<numRows; i++)
        {
            IList<int> temp = new List<int>();
            for(int j=0; j<=i; j++)
            {
                int num = nCr(i,j);
                temp.Add(num);
            }
            triangle.Add(temp);
        }
        return triangle;
    }
}