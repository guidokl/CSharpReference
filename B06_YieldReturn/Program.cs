using System.Collections.Generic;

// yield return         = Keywords to create an Iterator (State Machine)
//                        Enables "Deferred Execution" (Lazy Evaluation)
//                        Code executes only when the consumer requests the next item
//                        Memory Efficient: Returns elements one by one without buffering the whole collection

// --- Example 1
Console.WriteLine("--- Example 1 ---");

IEnumerable<string> stringValues = GetStringValues();

foreach (string value in stringValues)
{
    Console.WriteLine(value);
}

// Note: The "done" message only prints after the loop finishes iterating the last item
static IEnumerable<string> GetStringValues()
{
    yield return "one";
    yield return "two";
    yield return "three";
    yield return "four";
    yield return "five";

    Console.WriteLine("done");
}

// --- Example 2
Console.WriteLine("\n--- Example 2 ---");

IEnumerable<int> numbers = GetEvenNumbersLazy(10);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// 1. Deferred Execution (Lazy)
// The method returns immediately with an iterator. 
// The loop inside only runs when the caller (e.g., a foreach loop) asks for data.
static IEnumerable<int> GetEvenNumbersLazy(int max)
{
    for (int i = 0; i < max; i++)
    {
        // When 'yield return' is hit, the current value is returned to the caller,
        // and the method's current state (value of i) is saved. 
        // Execution pauses here and resumes after this line on the next request.
        if (i % 2 == 0) yield return i;
    }
}

// 2. Immediate Execution (Eager)
// This approach calculates ALL values and stores them in memory before returning anything.
// For large datasets, this causes high memory pressure and initial delay.
static IEnumerable<int> GetEvenNumbersEager(int max)
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < max; i++)
    {
        if (i % 2 == 0) numbers.Add(i);
    }
    return numbers;
}