// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void ArraySpiral(int[,] array, int number)
{
    int i = 0, j = 0;
    int counter = 1;
    for (int e = 0; e < number * number; e++)
    {
        int x = 0;
        do { array[i, j++] = counter++; } while (++x < number - 1);
        for (x = 0; x < number - 1; x++) array[i++, j] = counter++;
        for (x = 0; x < number - 1; x++) array[i, j--] = counter++;
        for (x = 0; x < number - 1; x++) array[i--, j] = counter++;
        ++i; ++j;
        number = number < 2 ? 0 : number - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int length = 4;
int[,] matrix = new int[length, length];
ArraySpiral(matrix, length);
PrintArray(matrix);
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();
