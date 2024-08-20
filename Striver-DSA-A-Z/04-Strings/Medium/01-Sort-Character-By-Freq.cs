namespace Striver_DSA_A_Z._04_Strings.Medium;

public partial class Strings {
    public string FrequencySort(string s) {

        Dictionary<char,int> freq = new Dictionary<char,int>();
        for(int i=0; i<s.Length;i++)
        {
            if(freq.ContainsKey(s[i]))
                freq[s[i]]+=1;
            else
                freq[s[i]]=1;

        }
        var sortedDictionary = freq.OrderByDescending(item =>item.Value);

        string ans ="";
        foreach(var (key,value) in sortedDictionary)
        {

            for(int i=0; i<value; i++)
                ans+=key;
        }
        return ans;
    }
}