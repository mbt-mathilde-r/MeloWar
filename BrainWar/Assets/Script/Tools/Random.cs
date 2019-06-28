using System;

public class Random
{
    public static int rand(int min, int max)
    {
        System.Random r = new System.Random();
        return r.Next(min, max);
    }
}
