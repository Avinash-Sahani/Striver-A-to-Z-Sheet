namespace Striver_DSA_A_Z._02_Arrays.Easy;

public partial class Arrays
{
    public static int IsSorted(int n, int []a) {
        int isSorted= 1;

        for(int i=0; i<n-1; i++)
        {
            if(a[i]>a[i+1])
            {
                isSorted = 0;
                break;
            }
                
 
        }
        return isSorted;
  
    }
}