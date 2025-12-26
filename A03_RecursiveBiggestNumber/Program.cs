int[] arr = [23, 4, 66, 42, 23, 1, 44];

int ReturnBiggestNum(int[] arr, int i = 1, int b = 0)
{
    // 1. Base Case: If we are at the end, return the value at the 'best' index
    if (i == arr.Length) return arr[b];

    // 2. Recursive Step: Update the 'best' index and pass it to the next call
    if (arr[i] > arr[b])
        return ReturnBiggestNum(arr, i + 1, i); // return the result of the next call
    else
        return ReturnBiggestNum(arr, i + 1, b); // return the result of the next call
}

Console.WriteLine(ReturnBiggestNum(arr));
Console.WriteLine();

// Using Math.Max allows to simplify the branching logic by expressing the problem as a
// comparison between the "current element" and the "maximum of the rest."
int ReturnBiggestNumMM(int[] arr, int i = 0)
{
    // Base case: If we're at the last element, it's the biggest of its own (one-element) subset
    if (i == arr.Length - 1)
        return arr[i];

    // Recursive step: Return the maximum of the current element 
    // vs. the maximum of everything that follows it
    return Math.Max(arr[i], ReturnBiggestNumMM(arr, i + 1));
}

Console.WriteLine(ReturnBiggestNumMM(arr));
Console.WriteLine();