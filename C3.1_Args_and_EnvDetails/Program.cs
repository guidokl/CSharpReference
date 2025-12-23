// Display a message and wait for Enter key to be pressed.
Console.WriteLine("***** Pro C# 10 with .NET 6 *****");
Console.WriteLine("Hello World!");
Console.WriteLine();
// Process any incoming args.
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("Arg: {0}", args[i]);
}

// Get arguments using System.Environment.
string[] theArgs = Environment.GetCommandLineArgs();
foreach (string arg in theArgs)
{
    Console.WriteLine("Arg: {0}", arg);
}

// Local method within the Top-level statements.
ShowEnvironmentDetails();

// --- END ---
Console.ReadLine();
return 0;

// --- METHODS ---
static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    // and other interesting details.
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}",
      Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}",
      Environment.Version);
}

// Table 3-1Select Properties of System.Environment
//ExitCode
//Gets or sets the exit code for the application

//Is64BitOperatingSystem
//Returns a bool to represent whether the host machine is running a 64-bit OS

//MachineName
//Gets the name of the current machine

//NewLine
//Gets the newline symbol for the current environment

//ProcessId (new in 10.0)
//Gets the unique identifier of the current process

//ProcessPath (new in 10.0)
//Returns the path of the executable that started the currently executing process; returns null when the path is not available

//SystemDirectory
//Returns the full path to the system directory

//UserName
//Returns the name of the user that started this application

//Version
//Returns a Version object that represents the version of the .NET Core platform