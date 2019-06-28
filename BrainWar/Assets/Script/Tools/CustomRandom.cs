using System;

public class CustomRandom
{
    public static int rand(int min, int max)
    {
        System.Random r = new System.Random();
        return r.Next(min, max);
    }
}
