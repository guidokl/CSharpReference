// IndexOf() & Substring() = Fundamental methods for searching and extracting string data
//                           IndexOf() returns the zero-based position of a character/string
//                           Substring() creates a new string from a specific range
//                           Common pattern: Find start/end indices -> Calculate length -> Extract
//                           Best Practice: Use .Length properties instead of hardcoded "magic numbers"

// --- Find what is (inside the parentheses)

string message = "Find what is (inside the parentheses).";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
Console.WriteLine();

// --- What is the value <span>between the tags</span>?

message = "What is the value <span>between the tags</span>?";

openingPosition = message.IndexOf("<span>");
closingPosition = message.IndexOf("</span>");

openingPosition += 6;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
Console.WriteLine();

// --- What is the value <span>between the tags</span>?
// without "magic value (6)"

message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closingSpan = "</span>";

openingPosition = message.IndexOf(openSpan);
closingPosition = message.IndexOf(closingSpan);

openingPosition += openSpan.Length;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
Console.WriteLine();