namespace Striver_DSA_A_Z._04_Strings.Easy;

public partial class Strings
{
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length==1)
            return strs[0];
        Array.Sort(strs);

        var firstWord = strs[0];
        var lastWord = strs[strs.Length-1];

        string prefix="";
        for(int i=0; i<firstWord.Length&&i<lastWord.Length; i++)
        {
            if(firstWord[i]==lastWord[i])
                prefix+=firstWord[i];
            else
                break;
        }
        return prefix;


    }
}