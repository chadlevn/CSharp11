using System.Numerics;

namespace GenericMath;

public class Example
{
    public static int Sum(int[] valuesToSum)
    {
        int result = 0;
        foreach (var value in valuesToSum)
            result += value;
        return result;
    }

    #region Generic Maths

    public static T Sum<T>(T[] valuesToSum) where T : INumber<T>
    {
        T result = T.AdditiveIdentity;
        foreach (var value in valuesToSum)
            result += value;
        return result;
    }

    #endregion
}