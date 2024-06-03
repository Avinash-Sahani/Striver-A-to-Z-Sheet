namespace Striver_DSA_A_Z._02_Arrays.Medium;
//URL : https://leetcode.com/problems/two-sum/
public partial class Arrays {
    public int[] TwoSum(int[] nums, int target) {
        
        int []indexes ={-1,-1};
        Dictionary<int,int> numbersIndex = new Dictionary<int,int>();
      
        for(int i=0; i<nums.Length; i++)
        {
            if(numbersIndex.TryGetValue(target - nums[i],out int val))
            {

                indexes[0] = i;
                indexes[1] = val;
        
                break;
            }
            else
                numbersIndex.TryAdd(nums[i],i);
        }
        return indexes;
    }
}