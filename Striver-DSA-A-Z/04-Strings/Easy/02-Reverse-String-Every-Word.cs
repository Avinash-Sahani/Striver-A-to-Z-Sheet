namespace Striver_DSA_A_Z._04_Strings.Easy;

public partial class  Strings
{
    public string ReverseWords(string s)
    {
        string reverseString = "";
        string temp = "";
        int i =0;

        while(i<s.Length)
        {

            char c  = s[i];
            if(c!=' ')
            {
                temp+=c;
            }

            else if(temp!="")
            {
                if(reverseString =="")
                    reverseString = temp ;
                else
                    reverseString = temp + " " + reverseString;
                temp ="";
            }

            if(i==s.Length-1 && temp!="")
            {
                if(reverseString =="")
                    reverseString = temp ;
                else
                    reverseString = temp + " " + reverseString;
            }

            i++;

        }

        return reverseString;
    }

}