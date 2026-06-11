namespace Lesson9_10.Helper;

public static class CustomExtention
{
    public static bool IsEven(this int number) => number % 2 == 0;
    public static bool ToBoolen(this int number) => Convert.ToBoolean(number);


}
