namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays {

    public List<int> Leaders(int n, int[] arr) {


        List<int> leaders = new List<int>();

        int max = arr[n-1];
        leaders.Add(max);
        for(int i=n-2; i>=0; i--)

        {

            if(arr[i]>=max)
            {
                leaders.Add(arr[i]);
                max = arr[i];
            }

        }
        leaders.Reverse();
        // code here

        return leaders;
    }
}