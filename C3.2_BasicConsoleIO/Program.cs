Console.WriteLine("***** Basic Console I/O *****");
GetUserData();

// --- END ---
Console.ReadLine();

// --- METHODS ---
static void GetUserData()
{
    // Get name and age.
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    Console.Write("Please enter your age: ");
    string userAge = Console.ReadLine();
    // Change echo color, just for fun.
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    // Echo to the console.
    Console.WriteLine("Hello {0}! You are {1} years old.",
    userName, userAge);
    // Restore previous color.
    Console.ForegroundColor = prevColor;

    // It is permissible for a given placeholder to repeat within a given string
    Console.WriteLine("{0}, Number {0}, Number {0}", 9);

    // It is possible to position each placeholder in any location within a string literal,
    // and it need not follow an increasing sequence
    Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);
}

//Table 3-2 Select Members of System.Console

//Beep()
//This method forces the console to emit a beep of a specified frequency and duration.

//BackgroundColor
//These properties set the background/foreground colors for the current output.

//ForegroundColor
//They may be assigned any member of the ConsoleColor enumeration.

//BufferHeightBufferWidth
//These properties control the height/width of the console’s buffer area.

//Title
//This property gets or sets the title of the current console.

//WindowHeightWindowWidthWindowTopWindowLeft
//These properties control the dimensions of the console in relation to the established buffer.

//Clear()
//This method clears the established buffer and console display area.