﻿public class Program
{
    public static int ExternalMain(nint args, int argLength)
    {
        var instance = new Program();
        instance.Main();
        return 0;
    }

    void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}