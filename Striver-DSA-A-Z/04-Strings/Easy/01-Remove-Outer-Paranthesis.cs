namespace Striver_DSA_A_Z._04_Strings.Easy;

public partial class Strings {
    public string RemoveOuterParentheses(string s) {


        int balance = 0;
        int length = s.Length;
        int i=0;
        while(i <length)
        {
            if(s[i]=='(')
            {
                if(balance==0)
                {
                    s = s.Remove(i,1);
                    length = s.Length;
                    i--;
                }
                balance++;
            }
            else

            {
                balance--;
                if(balance==0)
                {
                    s = s.Remove(i,1);
                    length = s.Length;
                    i--;
                }
            }

            i++;
        }
        return s;

    }
}