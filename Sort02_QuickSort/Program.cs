// QuickSort            = Efficient "Divide and Conquer" sorting algorithm
//                        Selects a 'Pivot' element and partitions the array around it
//                        Elements < Pivot move left, Elements > Pivot move right
//                        Lomuto Partitioning = Simpler logic, single-direction scan (left-to-right)
//                        Hoare Partitioning  = Higher performance, bi-directional scan (fewer swaps)

// --- TODO: Qs with Partition method / Median of three optimization

//int[] array1 = [12, 97, 3, 76, 55, 8, 7, 12];
//int[] array2 = [4, 3, 4];
//int[] array3 = [3, 4, 3];
//int[] array4 = [10, 4, 4];

int[] array = [97, 3, 76, 55, 8, 7, 12, 34, 54, 1, 54, 7, 17, 61, 41, 77, 7, 85, 5, 69, 99, 2];
// int[] array = [12, 97, 3, 76, 55, 8, 7, 12];

//  l   r                   P
// 97,  3, 76, 55,  8,  7, 12
//      l           r          
//  3, 97, 76, 55,  8,  7, 12
//          l           r           
//  3,  8, 76, 55, 97,  7, 12
//              l           r        
//  3,  8,  7, 55, 97, 76, 12
//              P 
//  3,  8,  7, 12, 97, 76, 55

DisplayArray("QuickSort Lomuto Partitioning: ", QuickSort(array, 0, array.Length - 1));

DisplayArray("QuickSort Hoare Partitioning: ", QuickSortArray(array, 0, array.Length - 1));

// --- QuickSort Lomuto Partitioning (pointers moving from left to right)
int[] QuickSort(int[] array, int leftIndex, int rightIndex)
{
    // 1. Base Case: Stop if the segment is invalid or single-element
    if (leftIndex >= rightIndex)
    {
        return array;
    }

    // 2. Setup Indices relative to the current recursion
    int pivotIndex = rightIndex;
    int i = leftIndex;           // 'i' marks the boundary of smaller elements
    int j = leftIndex;           // 'j' scans the array

    // 3. Partitioning Loop
    while (j < pivotIndex)
    {
        // Strict < ensures duplicates stay on the right (like 3, 4, 4)
        if (array[j] < array[pivotIndex])
        {
            (array[i], array[j]) = (array[j], array[i]);
            i++;
        }
        j++;
    }

    // 4. Place Pivot
    (array[i], array[pivotIndex]) = (array[pivotIndex], array[i]);

    // 5. Recursive Calls
    // Sort the left side (everything before the pivot)
    QuickSort(array, leftIndex, i - 1);

    // Sort the right side (everything after the pivot)
    QuickSort(array, i + 1, rightIndex);

    return array;
}

// --- QuickSort Hoare Partitioning (pointers moving from both ends)
// Source: https://code-maze.com/csharp-quicksort-algorithm/
int[] QuickSortArray(int[] array, int leftIndex, int rightIndex)
{
    var i = leftIndex;
    var j = rightIndex;
    var pivot = array[leftIndex];
    while (i <= j)
    {
        while (array[i] < pivot)
        {
            i++;
        }

        while (array[j] > pivot)
        {
            j--;
        }
        if (i <= j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }

    if (leftIndex < j)
        QuickSortArray(array, leftIndex, j);
    if (i < rightIndex)
        QuickSortArray(array, i, rightIndex);
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