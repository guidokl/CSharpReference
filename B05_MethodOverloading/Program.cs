// method overloading  = methods share same name, but different parameters
//                       name + parameters = signature
//                       methods must have a unique signature

// Top-Level Statements
int total = Calculator.Calc(2, 3);
Console.WriteLine(total);
total = Calculator.Calc(2, 3, 4);
Console.WriteLine(total);

// Helper Class defined at the bottom
class Calculator
{
    //public static int Calc(int a, int b) => a + b;
    //public static int Calc(int a, int b, int c) => a * b * c;

    // Two parameters are added
    public static int Calc(int a, int b)
    {
        return a + b;
    }
    // Three parameters are multiplied
    public static int Calc(int a, int b, int c)
    {
        return a * b * c;
    }
}