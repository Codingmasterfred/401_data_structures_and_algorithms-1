namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      int length = array.Length + 1;
      int[] newArray = new int[length];
      int midPoint = (length + 1) / 2;

      for (int i = 0; i < length; i++)
      {
        if (i < midPoint - 1)
        {
          newArray[i] = array[i];
        }
        else if (i == midPoint - 1)
        {
          newArray[i] = value;
        }
        else
        {
          newArray[i] = array[i - 1];
        }
      }

      return newArray;
    }
  }
}
