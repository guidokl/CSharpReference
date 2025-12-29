// Recursive Traversal  = Iterating through a collection using self-referencing calls
//                        Slicing (list[1..]) creates a NEW copy every step (High Memory Cost)
//                        Indexing (i + 1) passes the reference and tracks position (Efficient)
//                        Space Complexity: Slicing is O(n^2) vs. Indexing which is O(n)

List<string> myList = ["Spaceship", "Laser", "Warp", "Black Hole", "Gamma Ray", "Telport", "Gravity"];

// The range operator [1..] on a List<T> creates a new list(a shallow copy) in memory for every single call. 
// For a list of 1,000 items, you end up creating 1,000 list objects. This is O(n^2) space complexity.
int CountRecursiveSlicing(List<string> myList)
{
    // Base case: If the list is empty, we stop and return 0
    if (myList.Count == 0)
        return 0;

    // Recursive step: 1 (for the current head) + count of the remaining tail
    return 1 + CountRecursiveSlicing(myList[1..]);
}

Console.WriteLine(CountRecursiveSlicing(myList));
Console.WriteLine();

// We use a default parameter (int i = 0) so the first caller doesn't have to provide it
int CountRecursiveIndexing(List<string> myList, int i = 0)
{
    // Base case: If the index is equal to the count, we've reached the end
    if (i == myList.Count)
        return 0;

    // Recursive step: 1 (for the element at i) + result of checking the next index
    return 1 + CountRecursiveIndexing(myList, i + 1);
}

Console.WriteLine(CountRecursiveIndexing(myList));