namespace Striver_DSA_A_Z._04_Strings.Easy;

public partial class Strings
{
    public string LargestOddNumber(string num) {

        int lastIndex = -1;
        for(int i=num.Length-1; i>=0; i--)
        {
            char c = num[i];
            int numInt = int.Parse(c.ToString());
            if(numInt%2!=0)

            {
                lastIndex = i;
                break;
            }

        }
        string result ="";
        if(lastIndex !=-1)
            result = num.Substring(0,lastIndex+1);
        return result;
    }
}