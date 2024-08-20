namespace Striver_DSA_A_Z._04_Strings.Medium;

public partial class Strings {
    public int MaxDepth(string s) {

        int balance = 0;
        int maxBalance = 0;

        for(int i=0; i<s.Length-1; i++)
        {

            if(s[i]=='(')
            {
                balance++;
                if(balance>maxBalance)
                    maxBalance = balance;
            }
            else if(s[i]==')')
                balance--;
        }
        return maxBalance;
    }
}