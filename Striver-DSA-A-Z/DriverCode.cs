 using Striver_DSA_A_Z._02_Arrays;
using Striver_DSA_A_Z._03_BinarySearch;


var bs = new BinarySearch();
var array = new int[]
{
    5,7,7,8,8,10
};
foreach (var i in bs.SearchRange(array,8))
{
    Console.WriteLine(i + " ");
}