namespace Striver_DSA_A_Z._02_Arrays;

public  partial class Arrays {
    public int[][] Merge(int[][] intervals) {

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<List<int>> intervalsNew =  new List<List<int>>();
        intervalsNew.Add(intervals[0].ToList());



        for(int i=1; i<intervals.Length; i++)
        {
            var lastAdded = intervalsNew.LastOrDefault();
            var arr = intervals[i];

            if(arr[0]<=lastAdded[1])
            {
                var last =  Math.Max( arr[1] ,lastAdded[1]);
                List<int> newArr = new List<int>(){lastAdded[0],last};
                intervalsNew.RemoveAt(intervalsNew.Count-1);
                intervalsNew.Add(newArr);
            }
            else{
                intervalsNew.Add(arr.ToList());
            }
        }
        int[][] intervalsArray = intervalsNew.Select(innerList => innerList.ToArray()).ToArray();
        return intervalsArray;

    }
}