namespace Striver_DSA_A_Z._02_Arrays.Easy;

public partial class Arrays{
   
    
    
   
    //Complete this function
    //	Function to return a list containing the union of the two arrays. 
    //Using Three Pointers
    public List<int> findUnion(int[] arr1, int[] arr2, int n, int m)
    {
        int p1 = 0;
        int p2 = 0;
        int p3 = -1;
        List<int> union = new List<int>();
        int num=0;
     
        while(p1<n && p2<m)
        {
            if (arr1[p1] <= arr2[p2])
            {
                num = arr1[p1];
                AddToUnionArray();
                p1++;
            }
            else
            {
                num = arr2[p2];
                AddToUnionArray();
                p2++;
            }

            
        }
        while(p1<n)
        {
            
            
            num =arr1[p1];
            
            AddToUnionArray();
            p1++;
        }
        while(p2<m)
        {
            num =arr2[p2];
            
            AddToUnionArray();
            p2++;
            
        }

        return union;
        
        void AddToUnionArray()
        {
            if(p3==-1){
                union.Add(num);
                p3++;
            }
         
            else if(union[p3]!=num)
            {
                union.Add(num);
                p3++;
                
            }
        //Your code here
        //return list with correct order of elements
    }

    }
    
    
    
    
    //Another Approach using Hashset
    public static List<int> sortedArray(int []a, int []b)
    {

        HashSet<int> arr = new HashSet<int>();
        int p1 = 0, p2 = 0;
        while (p1 < a.Length && p2 <b.Length)
        {
            if (a[p1] <= b[p2])
            {
                arr.Add(a[p1]);
                p1++;
            }
            
            else
            {
                arr.Add(b[p2]);
                p2++;
            }
            
        }

        if (p1 < a.Length)
        {
            while(p1<a.Length)
                arr.Add(a[p1++]);
        }
        if (p2 < b.Length)
        {
            while(p2<b.Length)
                arr.Add(b[p2++]);
        }

        return arr.ToList();

    }
    //	Function to return a list containing the union of the two arrays. 
   
    
    
}