namespace Striver_DSA_A_Z._02_Arrays;

public partial class Arrays{
    public void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n) {


        int p1 = m-1;
        int p2 = 0;


        while(p1>=0 && p2<n && nums1[p1]>nums2[p2])
        {

            (nums1[p1],nums2[p2]) = (nums2[p2],nums1[p1]);


            p1--;
            p2++;
        }

        Array.Sort(nums1, 0,m);
        Array.Sort(nums2);

        p1 = m;
        p2 = 0;

        while(p2<n)
        {

            (nums1[p1],nums2[p2]) = (nums2[p2],nums1[p1]);
            p1++;
            p2++;
        }



    }
}