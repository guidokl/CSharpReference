Console.WriteLine("***** System Data Types and Keywords *****");
LocalVarDeclarations();
DefaultDeclarations();
NewingDataTypesWith9();

// --- END ---
Console.ReadLine();

// --- METHODS ---

static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declarations:");
    // Local variables are declared and initialized as follows:
    // dataType varName = initialValue;
    int myInt = 0;
    string myString;
    myString = "This is my character data";
    // Declare 3 bools on a single line.
    bool b1 = true, b2 = false, b3 = b1;
    // Use System.Boolean data type to declare a bool.
    System.Boolean b4 = false;
    Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
        myInt, myString, b1, b2, b3, b4);
    Console.WriteLine();
}

static void DefaultDeclarations()
{
    Console.WriteLine("=> Default Declarations:");
    int myInt = default;
    Console.WriteLine(myInt);
}

static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool();              // Set to false.
    int i = new int();                // Set to 0.
    double d = new double();          // Set to 0.
    DateTime dt = new DateTime();     // Set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

// C# 9.0 added a shortcut for creating variable instances. This shortcut is simply using the keyword new() without the data type. The updated version of NewingDataTypes is shown here
static void NewingDataTypesWith9()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new();              // Set to false.
    int i = new();               // Set to 0.
    double d = new();            // Set to 0.
    DateTime dt = new();         // Set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

//Table 3-4 The Intrinsic Data Types of C#

//C# Shorthand
//CLS Compliant?
//System Type
//Range
//Meaning in Life

//bool
//Yes
//Boolean
//true or false
//Represents truth or falsity

//sbyte
//No
//SByte
//–128 to 127
//Signed 8-bit number

//byte
//Yes
//Byte
//0 to 255
//Unsigned 8-bit number

//short
//Yes
//Int16
//–32,768 to 32,767
//Signed 16-bit number

//ushort
//No
//UInt16
//0 to 65,535
//Unsigned 16-bit number

//int
//Yes
//Int32
//–2,147,483,648 to 2,147,483,647
//Signed 32-bit number

//uint
//No
//UInt32
//0 to 4,294,967,295
//Unsigned 32-bit number

//long
//Yes
//Int64
//–9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
//Signed 64-bit to number

//ulong
//No
//UInt64
//0 to 18,446,744,073,709,551,615
//Unsigned 64-bit number

//char
//Yes
//Char
//U+0000 to U+ffff
//Single 16-bit Unicode character

//float
//Yes
//Single
//–3.4 1038 to +3.4 1038
//32-bit floating-point number

//double
//Yes
//Double
//±5.0 10–324 to ±1.7 10308
//64-bit floating-point number

//decimal
//Yes
//Decimal
//(–7.9 x 1028 to 7.9 x 1028)/(100 to 28)
//128-bit signed number

//string
//Yes
//String
//Limited by system memory
//Represents a set of Unicode characters

//object
//Yes
//Object
//Can store any data type in an object variable
//The base class of all types in the .NET universe