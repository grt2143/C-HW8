// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


int dimX = ReadInteger("Введите размер X: ");
int dimY = ReadInteger("Введите размер Y: ");
int dimZ = ReadInteger("Введите размер Z: ");
int count2DNumbers = 300;
if (dimX * dimY * dimZ <= count2DNumbers)
{
    int[,,] array = CreateArray3D(dimX, dimY, dimZ);
    for (int d1 = 0; d1 < array.GetLength(0); d1++)
    {
        Console.WriteLine($"d1 = {d1}");
        for (int d2 = 0; d2 < array.GetLength(1); d2++)
        {
            for (int d3 = 0; d3 < array.GetLength(2); d3++)
                Console.Write($"{array[d1, d2, d3]} [{d1},{d2},{d3}] ");
            Console.WriteLine(); 
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Заполнить массив двухзначными неповторяющимися числами нельзя");
}
int[,,] CreateArray3D(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int value = 10;
    int[] twoDigitValues = new int[89];
    for (int i = 0; i < twoDigitValues.Length; i++)
        twoDigitValues[i] = value++;
    int minValueIndex = 0;
    for (int d1 = 0; d1 < array.GetLength(0); d1++)
        for (int d2 = 0; d2 < array.GetLength(1); d2++)
            for (int d3 = 0; d3 < array.GetLength(2); d3++)
            {
                int valueIndex = new Random().Next(minValueIndex, twoDigitValues.Length);
                array[d1, d2, d3] = twoDigitValues[valueIndex];
                twoDigitValues[valueIndex] = twoDigitValues[minValueIndex];
                minValueIndex++;
            }
    return array;
}
int ReadInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}