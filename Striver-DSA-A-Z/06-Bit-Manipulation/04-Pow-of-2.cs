namespace Striver_DSA_A_Z._06_Bit_Manipulation;

public partial class BitManipulation
{
    public bool IsPowerOfTwo(int n) {
        if(n<=0)
            return false;

        return (n & n-1) == 0;
    }
}