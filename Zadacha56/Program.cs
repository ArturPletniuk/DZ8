// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

void NumberMinSumElements(int[,] array)
{
    int minNumber = 0;
    int minSumNumber = 0;
    int sumNumber = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minNumber += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumNumber += array[i, j];
        if (sumNumber < minNumber)
        {
            minNumber = sumNumber;
            minSumNumber = i;
        }
        sumNumber = 0;
    }
    Console.Write($"{minSumNumber + 1} строка");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[6, 4];
ArrayRandom(matrix);
PrintArray(matrix);
Console.WriteLine();
NumberMinSumElements(matrix);
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();
