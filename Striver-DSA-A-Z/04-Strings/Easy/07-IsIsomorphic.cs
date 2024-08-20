namespace Striver_DSA_A_Z._04_Strings.Easy;

public partial class Strings{
    public bool IsIsomorphic(string s, string t) {
        var dS = new Dictionary<char, char>();
        var dT = new Dictionary<char, char>();
        for (var i = 0; i < s.Length; i++) {
            dS.TryAdd(s[i], t[i]);
            dT.TryAdd(t[i],s[i]);

            if(t[i]!=dS[s[i]] || s[i]!=dT[t[i]])
                return false;
        }
        return true;



    }
}