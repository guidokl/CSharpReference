// Recursion            = A method calling itself to solve a smaller instance of the problem
//                        Requires a "Base Case" to stop execution (prevent StackOverflow)
//                        Requires a "Recursive Step" that moves closer to the base case
// Optimization         = Standard recursion can be memory-intensive
//                        Array slicing (data[1..]) often creates copies (Heap Allocations)
//                        Span<T> allows slicing memory without copying (Zero-Allocation)

int[] arr = [2, 4, 9, 123, 4, 66, 6, 3, 9, 42];
int sum = 0;
int stage = 1;

// 0. The "Naive" Approach (Avoid this)
// Problem: This function relies on external variables ('stage', 'sum').
// It is "impure" and cannot be easily reused or run in parallel threads.
int SumArr(int[] arr)
{
    if (stage > arr.Length)
    {
        return 0; // Base Case
    }
    else
    {
        // Recursion logic mixed with side effects (modifying global 'sum')
        sum = arr[stage - 1] + SumArr(arr[stage..]);
        stage++;
        return sum;
    }
}

Console.WriteLine(SumArr(arr));

// 1. The "Pure" Recursion (Functional Approach)
// In computer science, a recursive function should ideally be "pure":
// dependent only on its inputs, returning a result without changing global state.
// Note: While 'currentArr[1..]' is readable, it creates a NEW array copy
// in memory for every single step. This is slow for large data.
int SumArr1(int[] currentArr)
{
    // Base Case: When the array is empty
    if (currentArr.Length == 0) return 0;

    // Recursive Step: Head (currentArr[0]) + Sum of the Rest
    return currentArr[0] + SumArr1(currentArr[1..]);
}

Console.WriteLine(SumArr1(arr));

// 2. The Performant Approach (Index-Based)
// As you are retraining for software development, resource management is key.
// To avoid copying arrays, we pass the SAME array reference but update a simple integer index.
// This is very fast and uses minimal memory.
int SumArr2(int[] data, int index = 0)
{
    if (index >= data.Length) return 0;
    return data[index] + SumArr2(data, index + 1);
}

Console.WriteLine(SumArr2(arr));

// 3. The Modern High-Performance Approach (Span<T>)
// ReadOnlySpan<T> provides a "view" over a section of memory.
// When we do 'data[1..]', it does NOT create a new array; it just shifts the viewing window.
// Combines the clean syntax of Approach #1 with the speed of Approach #2.
int SumArr3(ReadOnlySpan<int> data)
{
    if (data.IsEmpty) return 0;
    return data[0] + SumArr3(data[1..]);
}

Console.WriteLine(SumArr3(arr));