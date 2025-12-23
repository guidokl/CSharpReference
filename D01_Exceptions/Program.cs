// https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/

// Exception Handling   = Mechanism to detect and handle runtime errors to prevent program crashes
//                        try block contains code that may cause an exception
//                        catch block executes only if a specific exception is thrown
// checked Keyword      = Explicitly enables overflow checking for integer arithmetic
//                        By default, C# may wrap values on overflow; checked forces an exception

// 1. Handling Arithmetic Overflow
// The 'checked' keyword ensures that if an integer calculation exceeds the limit,
// an exception is thrown rather than silently wrapping around to a negative number.
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;

        // This addition exceeds the maximum value a 32-bit integer can hold (2,147,483,647)
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

// 2. Handling Null References
try
{
    // 'str' is declared but set to null (it points to nothing in memory)
    string? str = null;

    // Attempting to access a property (.Length) of a null object causes a crash
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

// 3. Handling Array Indexing Errors
try
{
    // An array of size 5 contains indices 0, 1, 2, 3, and 4
    int[] numbers = new int[5];

    // Accessing index 5 is out of bounds
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

// 4. Handling Math Errors
try
{
    int num3 = 10;
    int num4 = 0;

    // Integer division by zero is undefined
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");