// https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expressions
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference

using System.Text.RegularExpressions;

string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
string[] names = [ "Mr. Henry Hunt", "Ms. Sara Samuels", 
                   "Abraham Adams", "Ms. Nicole Norris" ];

foreach (string name in names)
    Console.WriteLine(Regex.Replace(name, pattern, String.Empty));