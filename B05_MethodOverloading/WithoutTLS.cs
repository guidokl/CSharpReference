using System;
internal class Program1
{
    static void Main(string[] args)
    {
        int total = Calc(2, 3);
        Console.WriteLine(total);
        total = Calc(2, 3, 4);
        Console.WriteLine(total);
        Console.ReadKey();
    }

    // Two parameters are added
    static int Calc(int a, int b)
    {
        return a + b;
    }

    // Three parameters are multiplied
    static int Calc(int a, int b, int c)
    {
        return a * b * c;
    }
}