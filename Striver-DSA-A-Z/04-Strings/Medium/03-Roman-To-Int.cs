namespace Striver_DSA_A_Z._04_Strings.Medium;

public partial class Strings {
    public int RomanToInt(string s) {
        var romans = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        if(s.Length ==1)   
            return romans[s[0]];

        int p1=0;
        int p2 = 1;
        int ans = 0;
        while(p1<s.Length && p2<s.Length)
        {
            int  val1= romans[s[p1]];
            int  val2= romans[s[p2]];

            if(val1>=val2)
            {
                ans+=val1;
                p2++;
                p1++;
  
            }
            else
            {
                ans+= val2-val1;
                p1+=2;
                p2+=2;
            }
   
    

        }
        if(p1<s.Length)
            ans+=romans[s[p1]];
        return ans;

    }
}