namespace CodeChallenges
{
  public class CodeChallenge4
  {
    public static int GetNthNumberInFibonacciSequence(int n)
    {
      if (n < 0)
      {
        throw new ArgumentException("n must be a non-negative integer.");
      }

      if (n == 0)
      {
        return 0;
      }

      int a = 0;
      int b = 1;

      for (int i = 2; i <= n; i++)
      {
        int temp = a + b;
        a = b;
        b = temp;
      }

      return a;
    }


    public static int[] RowSums(int[][] matrix)
    {
      int rows = matrix.Length;
      int[] rowSums = new int[rows];

      for (int i = 0; i < rows; i++)
      {
        int sum = 0;
        for (int j = 0; j < matrix[i].Length; j++)
        {
          sum += matrix[i][j] != null ? matrix[i][j] : 0;
        }
        rowSums[i] = sum;
      }

      return rowSums;
    }
  }
}
