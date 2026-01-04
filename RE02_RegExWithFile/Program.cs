using System.Text.RegularExpressions;

// ----------------------------------------------------------
// --- Locate File
string filePath = "text.txt";

if (!File.Exists(filePath))
{
    Console.WriteLine($"Error: '{filePath}' not found.");
    return;
}

// ----------------------------------------------------------
// --- RegEx Pattern
// Example: IP Addresses
string pattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";

// ----------------------------------------------------------
// --- OPTION A: Read All Text (Global Search)
Console.WriteLine("--- OPTION A: Processing entire file at once ---");

// Reads the entire file into a single string, preserving line breaks (\r\n).
// Note: Standard Regex '.' will stop matching at these newlines unless RegexOptions.Singleline is used.
string fileContent = File.ReadAllText(filePath);

// MatchCollection: A read-only collection holding ALL successful matches found.
// Unlike Regex.Match (which stops at the first hit), Regex.Matches returns everything.
MatchCollection allMatches = Regex.Matches(fileContent, pattern);

Console.WriteLine($"Total matches found: {allMatches.Count}");

foreach (Match match in allMatches)
{
    // match.Index: Zero-based character position where this match starts.
    Console.WriteLine($" - Found: {match.Value} (Index: {match.Index})");
}

Console.WriteLine(new string('-', 30));

// ----------------------------------------------------------
// --- OPTION B: Read Line by Line
Console.WriteLine("--- OPTION B: Processing line by line ---");

string[] fileLines = File.ReadAllLines(filePath);

for (int i = 0; i < fileLines.Length; i++)
{
    Match match = Regex.Match(fileLines[i], pattern);
    if (match.Success)
    {
        // 1. (i + 1): Converts zero-based index (0) to human-readable line number (1).
        // 2. :00    : Formatting code. Pads numbers < 10 with a leading zero.
        //             Result: "1" becomes "01", "10" stays "10".
        Console.WriteLine($"[Line {i + 1:00}] Found: {match.Value}");
    }
}