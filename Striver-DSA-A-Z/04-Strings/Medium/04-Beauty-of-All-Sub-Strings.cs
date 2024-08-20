namespace Striver_DSA_A_Z._04_Strings.Medium;

public partial class Strings
{
    public int BeautySum(string s) {

        Dictionary<char,int> freq= new Dictionary<char,int>();
        int beautySum = 0;
        for(int i=0; i<s.Length; i++)
        {

            for(int j=i; j<s.Length; j++ )
            {

                char c = s[j];
                if(freq.ContainsKey(c))
                    freq[c]+=1;
                else
                    freq[c]=1;
                var values = freq.Values;
                int max =int.MinValue;
                int min = int.MaxValue;
                foreach(var value in values)
                {
                    if(value==0)
                        continue;
                    max = Math.Max(max,value);
                    min = Math.Min(min,value);

                }
                beautySum+=max - min;
            }
            freq.Clear();
        }
        return beautySum;
    }
}