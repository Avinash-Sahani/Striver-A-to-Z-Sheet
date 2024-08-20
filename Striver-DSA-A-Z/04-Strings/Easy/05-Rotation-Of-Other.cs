namespace Striver_DSA_A_Z._04_Strings.Easy;

public partial class Strings {
    public bool RotateString(string s, string goal) {

        if(s==goal)
            return true;


        string rotated = "";



        for(int i=0; i<goal.Length; i++)
        {


            rotated = goal.Remove(0,i+1) + goal.Substring(0,i+1);
            if(rotated==s)
                return true;

        }


        return false;
    }
}