﻿unsafe class Program
{
    public static int ExternalMain(nint args, int argLength)
    {
        var instance = new Program();
        instance.Main();
        return 0;
    }

    void Main()
    {
        File.WriteAllText(@"C:\d.txt", DateTime.Now.ToString());
        Console.WriteLine("Injected!");
    }
}