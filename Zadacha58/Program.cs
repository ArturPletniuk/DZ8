// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int EnteringValues(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
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

void PrintArrayMatrix(int[,] array)
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

int rows = EnteringValues("Введите количество строк: ");
int columns = EnteringValues("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] AnotherArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];
ArrayRandom(array);
PrintArrayMatrix(array);
Console.WriteLine();
ArrayRandom(AnotherArray);
PrintArrayMatrix(AnotherArray);
Console.WriteLine();
if (array.GetLength(0) != AnotherArray.GetLength(1))
{
    Console.WriteLine(" Перемножить нельзя! ");
    Console.WriteLine();
    Console.Write("Exit.");
    Console.ReadLine();
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < AnotherArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * AnotherArray[k, j];
        }
    }
}
PrintArrayMatrix(resultArray);
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();
