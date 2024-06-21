namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays {
    public int LongestConsecutive(int[] nums)
    {
        int max = 0;
        int count = 0;
        HashSet<int> numsSet = new HashSet<int>();
        foreach (var num in nums)
        {
            numsSet.Add(num);
        }
        
        foreach (var num in nums)
        {
            count = 0;
            if (!numsSet.Contains(num - 1))
            {
                int small = num;
                
                while (numsSet.Contains(small++))
                    count++;

                max = Math.Max(count, max);
            }
            
            
        }

        return max;
    }
}