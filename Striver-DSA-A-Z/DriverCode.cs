




using Striver_DSA_A_Z._02_Arrays.Medium;


int[][] jaggedArray = new int[1][]
{
    new int[] { 1, 0, 3 },

};
Arrays.SetZeroes(jaggedArray);
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(jaggedArray[i][j] +"  ");
    }
    Console.WriteLine();
}