Console.WriteLine("***** Formatting Numerical Data *****");
FormatNumericalData();
// Using string.Format() to format a string literal.
string userMessage = string.Format("100000 in hex is {0:x}", 100000);
Console.WriteLine(userMessage);

// --- END ---
Console.ReadLine();

// --- METHODS ---
static void FormatNumericalData()
{
    Console.WriteLine("The value 99999 in various formats:");
    Console.WriteLine("c format: {0:c}", 99999);
    Console.WriteLine("d9 format: {0:d9}", 99999);
    Console.WriteLine("f3 format: {0:f3}", 99999);
    Console.WriteLine("n format: {0:n}", 99999);
    // Notice that upper- or lowercasing for hex
    // determines if letters are upper- or lowercase.
    Console.WriteLine("E format: {0:E}", 99999);
    Console.WriteLine("e format: {0:e}", 99999);
    Console.WriteLine("X format: {0:X}", 99999);
    Console.WriteLine("x format: {0:x}", 99999);
}

//Table 3-3.NET Core Numerical Format Characters

//C or c
//Used to format currency. By default, the flag will prefix the local cultural symbol (a dollar sign [$] for US English).

//D or d
//Used to format decimal numbers. This flag may also specify the minimum number of digits used to pad the value.

//E or e
//Used for exponential notation. Casing controls whether the exponential constant is uppercase (E) or lowercase (e).

//F or f
//Used for fixed-point formatting. This flag may also specify the minimum number of digits used to pad the value.

//G or g
//Stands for general. This character can be used to format a number to fixed or exponential format.

//N or n
//Used for basic numerical formatting (with commas).

//X or x
//Used for hexadecimal formatting. If you use an uppercase X, your hex format will also contain uppercase characters.