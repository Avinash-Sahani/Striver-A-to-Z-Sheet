namespace Striver_DSA_A_Z._02_Arrays._03_Hard;

public partial class Arrays {


    public static IList<IList<int>> ThreeSum(int[] nums) {


        IList<IList<int>> triplets = new List<IList<int>>();

        Array.Sort(nums);
        int n = nums.Length;
        int sum =0;
        for(int i=0; i<n; i++)
        {

            if(i!=0 && nums[i-1]==nums[i])
                continue;
            int j =i+1;
            int k = n-1;
            while(j<k)
            {
                sum = nums[i] + nums[j] + nums[k];

                if(sum==0)
                {
                    triplets.Add(new List<int>(){nums[i],nums[j],nums[k]});
                    j++;
                }
                else if(sum>0)
                    k--;
                else
                    j++;

                while(j<k && j!=i+1 && nums[j]==nums[j-1])
                    j++;



                while(j<k && k!=n-1 && nums[k]==nums[k+1])
                    k--;



            }


        }
        return triplets;



    }
    }
