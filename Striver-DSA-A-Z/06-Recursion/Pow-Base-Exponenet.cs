namespace Striver_DSA_A_Z._06_Recursion;
//Problem Link : https://leetcode.com/problems/powx-n/
public partial class Recursion
{

    public double MyPow(double x, int n) {
        if(n==1)
            return x;

        double ans = 1;
        var isNegative  = false;
        if(n<0)
        {
            isNegative = true;
            n = n*-1;
        }
        while(n>0)
        {
            if(n%2==0)
            {
                x = x *x;
                n/=2;
            }
            else
            {

                n = n -1;
                ans = ans *x;
            }


        }

        return isNegative ?(double)(1.0) / (double)(ans) :ans;


    }
}