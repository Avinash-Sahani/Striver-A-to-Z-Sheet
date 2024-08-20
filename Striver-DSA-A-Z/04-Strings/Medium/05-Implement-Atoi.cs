namespace Striver_DSA_A_Z._04_Strings.Medium;

public partial class Strings
{
    public int MyAtoi(string s) {

        int n = s.Length;

        bool isNegative = false;
        string ans = "";
        bool isPositive = false;
        s = s.TrimStart().TrimEnd();
        for(int i=0 ; i<s.Length; i++)
        {
            char c = s[i];
            if(c=='-' &&   i==0)
                isNegative = true;
            else  if(c=='+' &&  i==0 )
                isPositive = true;
            else if(!char.IsNumber(c) || c==' ')
                break;
            else
            {

                ans+=c;
            }


        }
        if(ans=="")
            return 0;
        bool isConverted = Int32.TryParse(ans, out int number);
        if(isNegative)
            number *=-1;
        if(!isConverted)
        {
            number = isNegative ? Int32.MinValue  : Int32.MaxValue;
        }


        return number;

        // any non integer stop there
        // no trailing spaces

    }
}