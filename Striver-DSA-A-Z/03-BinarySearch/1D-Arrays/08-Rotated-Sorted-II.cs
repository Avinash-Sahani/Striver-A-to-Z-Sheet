namespace Striver_DSA_A_Z._03_BinarySearch;

public partial class BinarySearch {
   public bool SearchRotatedII(int[] nums, int target)
   {
      int low  = 0;
      int high = nums.Length -1;
      while(low<=high)
      {
         int mid = low + (high-low)/2;
         if(nums[mid]==target)
            return true;
         else if(nums[low] ==nums[mid] && nums[mid]==nums[high])
         {
            low++;
            high--;

         }
         else if(nums[low]<=nums[mid] )
         {
            if(target >=nums[low] && target<=nums[mid])
               high = mid -1 ;
            else
               low =  mid +1;
         }
         else
         {
            if(target >=nums[mid] && target<=nums[high])
               low =  mid +1;
            else
               high = mid -1;
         }



      }
      return false;
   }
}