namespace Striver_DSA_A_Z._06_Bit_Manipulation._06_Set;

public partial class BitManipulation

{
    public int setBit(int N) {
        int n = N;
        int count = 1;
        while((n&1) !=0)
        {
            count++;
            n = n >>1;
        }

        int leftshift = 1 << (count-1);
        return ( N | leftshift);
    }
}