class Solver
{
    static int solve(int[] arr)
    {
        int maxDiff = -1;
        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = i - 1; j > -1; j--)
            {
                if (arr[i] - arr[j] > maxDiff && arr[i] - arr[j] != 0)
                {
                    maxDiff = arr[i] - arr[j];
                }
            }
        }
        return maxDiff;

    }

    public static void Main()
    {
        int[] arr = new int[] { 2, 3, 10, 2, 4, 8, 1 };
        int maxDiff = Solver.solve(arr);

        Console.WriteLine(maxDiff);

    }
}


