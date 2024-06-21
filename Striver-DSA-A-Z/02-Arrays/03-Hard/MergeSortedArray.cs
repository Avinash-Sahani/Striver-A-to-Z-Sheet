namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays
{
    public void SwapIfGreater(int[] nums1, int l, int[] nums2, int r){
        if(nums1[l]>nums2[r])
            (nums1[l],nums2[r]) = (nums2[r],nums1[l]);
    }
    public  void Merge(int[] nums1, int m, int[] nums2, int n) {

        if(n==0)
            return;
        int left= 0;
        int right = 0;
        int total_size = m+n;
        int gap = n+m;
        while(true)
        {
            if(gap==1)
                break;
            gap =(int)Math.Ceiling((decimal)gap/2);
            left = 0;
            right = gap;
            while(right<total_size)
            {
                if(left<m && right<m)
                {
                    SwapIfGreater(nums1,  left, nums1,  right);

                }
                else if(left>=m && right>=m)
                {
                    int l  = left - m;
                    int r = right - m;
                    SwapIfGreater(nums2,  l, nums2,  r)     ;
                }
                else if(left<m && right>=m)
                {

                    int l  = left;
                    int r = right - m;
                    SwapIfGreater(nums1,  l, nums2,  r)    ;
                }
                left++;
                right++;
            }

        }

        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }
    }


}