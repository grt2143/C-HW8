// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int m = ReadInteger("Введите количество строк ");
int n = ReadInteger("Введите количество столбцов ");
int minimum = -99;
int maximum = 99;

int[,] array = FillRandomArray(m, n, minimum, maximum);
Console.WriteLine("Исходный массив:");
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1) - 1; j++)
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > array[i, j])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }

Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintArray(array);

int[,] FillRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int ReadInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}