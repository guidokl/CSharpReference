// https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expressions
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference

using System.Text.RegularExpressions;

// --- Replace substrings

// instead of double escaping like:
// string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
// use Verbatim Strings:
// The @ tells the compiler to treat '\' as a normal character.
// We only need to escape the dot once for the Regex engine.
string pattern = @"(Mr\.? |Mrs\.? |Miss |Ms\.? )";
string[] names = [ "Mr. Henry Hunt", "Ms. Sara Samuels",
                   "Abraham Adams", "Ms. Nicole Norris" ];

foreach (string name in names)
    Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

Console.WriteLine("-----------------");

// --- Identify duplicated words

pattern = @"\b(\w+?)\s\1\b";
string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";
foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
    Console.WriteLine($"{match.Value} (duplicates '{match.Groups[1].Value}') at position {match.Index}");

Console.WriteLine("-----------------");