// Sorting Algorithms   = Techniques to arrange data in a specific order (e.g., ascending)
//                        BubbleSort    = Repeatedly steps through the list, swaps adjacent elements if wrong order
//                        SelectionSort = Finds the minimum element and places it at the beginning
//                        Complexity    = Both are O(n^2), generally slow for large datasets
//                        Swapping      = Using C# Tuples (a, b) = (b, a) is cleaner than temp variables

int[] array = [97, 3, 76, 55, 8, 7, 12, 34, 54, 1, 54, 7, 17, 61, 41, 77, 7, 85, 5, 69, 99, 2];

// Passing a copy to preserve the original array
// BubbleSort((int[])array.Clone()); // Oldest (requires casting)
// BubbleSort(array.ToArray());      // LINQ (readable)
// BubbleSort([.. array]);           // C# 12 (Modern, concise)

DisplayArray("BubbleSort: ", BubbleSort([.. array])); 
DisplayArray("SelectionSort: ", SelectionSort([.. array]));


// --- BubbleSort
int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                (array[j + 1], array[j]) = (array[j], array[j + 1]);

                //int temp = array[j];
                //array[j] = array[j + 1];
                //array[j + 1] = temp;
            }
        }
    }
    return array;
}

// --- SelectionSort
int[] SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int indexOfLeast = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[indexOfLeast])
            {
                indexOfLeast = j;
            }
        }

        if (indexOfLeast != i)
        {
            (array[indexOfLeast], array[i]) = (array[i], array[indexOfLeast]);

            //int temp = array[i];
            //array[i] = array[indexOfLeast];
            //array[indexOfLeast] = temp;
        }
    }
    return array;
}

// --- Output method
void DisplayArray(string heading, int[] array)
{
    Console.WriteLine(heading);
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    // [^1] accesses the last element of the array
    Console.WriteLine(array[^1]);
}