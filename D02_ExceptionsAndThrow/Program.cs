// https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/

// Exception Propagation = The process of an exception "bubbling up" the call stack until caught
//                         If Method A calls B, and B fails, the error passes back to A
// Re-throwing (throw;)  = Catches an exception but passes it up the stack anyway
//                         Crucial: using 'throw;' preserves the original Stack Trace
// Wrapping Exceptions   = Catching a low-level error and throwing a new, higher-level exception
//                         The original error is usually attached as the 'InnerException'

// 1. Top-Level Safety Net
// This catch block handles any errors that were re-thrown or unhandled by lower methods.
try
{
    OperatingProcedure1();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Exiting application.");
}

static void OperatingProcedure1()
{
    string[][] userEnteredValues = new string[][]
    {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
    };

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            BusinessProcess1(userEntries);
        }
        catch (Exception ex)
        {
            // 2. Context Inspection
            // We check the StackTrace to confirm the error originated where we expect.
            if (ex.StackTrace.Contains("BusinessProcess1"))
            {
                if (ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Corrective action taken in OperatingProcedure1");
                }
                else if (ex is DivideByZeroException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                    // 3. Re-throwing
                    // We handled the logging/partial correction above, but we cannot fix the root issue.
                    // 'throw;' pushes the exact same exception instance up to Main().
                    // It preserves the stack trace, showing the error started in BusinessProcess1.
                    throw;
                }
                else
                {
                    // 4. Wrapping (Inner Exceptions)
                    // We catch a specific error but want to report a generic "ApplicationException" to the user.
                    // We pass 'ex' as the second parameter to preserve the original error details.
                    throw new ApplicationException("An error occurred - ", ex);
                }
            }
        }
    }
}

static void BusinessProcess1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        // 5. Throwing New Exceptions
        // Here we catch the system error and throw a NEW exception with a custom message.
        // NOTE: This resets the stack trace to this line unless we attach the inner exception.
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;
        }
    }
}

// Things to avoid when throwing exceptions
// - Don't use exceptions to change the flow of a program as part of ordinary execution. Use exceptions to report and handle error conditions.
// - Exceptions shouldn't be returned as a return value or parameter instead of being thrown.
// - Don't throw System.Exception, System.SystemException, System.NullReferenceException, or System.IndexOutOfRangeException intentionally from your own source code.
// - Don't create exceptions that can be thrown in debug mode but not release mode. To identify runtime errors during the development phase, use Debug.Assert instead.