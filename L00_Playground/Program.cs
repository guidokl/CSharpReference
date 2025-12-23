string str1 = "Fourty Two!";

int num1 = 0;
int num2 = 7;
int num3 = 42;

int[] arrNums1 = [2, 3, 5, 7, 9, 11];
int[] arrNums2 = new int[5]; // Size 5

Console.WriteLine($"Hello, {str1}!");

for (int i = 0; i < arrNums1.Length; i++)
{
    Console.WriteLine($"{arrNums1[i],2}");
}
