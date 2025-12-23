// LastIndexOf()        = Returns the index of the last occurrence of a specific character/string
//                        Scans the string backwards (Right-to-Left)
// String Iteration     = Processing multiple matches typically requires a loop
//                        Common approach: Find match -> Extract -> Update string or index
//                        Substring(int startIndex) returns all characters to the end of the string

// --- (What if) I am (only interested) in the last (set of parentheses)?

string message = "(What if) I am (only interested) in the last (set of parentheses)?";

int openingPosition = message.LastIndexOf('(');
openingPosition += 1;
int closingPosition = message.LastIndexOf(')');

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
Console.WriteLine();

// --- (What if) there are (more than) one (set of parentheses)?
openingPosition = 0;
closingPosition = 0;

message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;
    openingPosition += 1;
    closingPosition = message.IndexOf(')');

    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
    // When you use Substring() without specifying a length input parameter, 
    // it will return every character after the starting position you specify.
    // With the string being processed, message = "(What if) there are (more than) one (set of parentheses)?", 
    // there's an advantage to removing the first set of parentheses (What if) from the value of message. 
    // What remains is then processed in the next iteration of the while loop.
}