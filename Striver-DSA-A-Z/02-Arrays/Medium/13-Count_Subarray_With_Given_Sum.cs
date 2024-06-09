namespace Striver_DSA_A_Z._02_Arrays.Medium;

public partial class Arrays {
    
    public int SubarraySum(int[] nums, int k) {

        var total_subarrays = 0;
        var sum=0;
        var previousNums = new Dictionary<int, int>();
        
        for (var i=0; i<nums.Length; i++)
        {
            var num = nums[i];
            sum += num;

            if (sum == k)
            {
                total_subarrays++;
           
            }
            int remainder = sum - k;
            if (previousNums.TryGetValue(remainder,out int count))
            {
                

                total_subarrays += count;
            }
            

            if (previousNums.ContainsKey(sum))
                previousNums[sum] +=1 ;
            else
                previousNums.Add(sum, 1);



        }
        
        return total_subarrays;
    
    }

        
}