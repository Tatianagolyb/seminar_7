// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    {
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                result[i, j] = new Random().Next(minValue, maxValue+1);

    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int AverageSum(int[,] inArray)
{
    int sum=0;
    {
       for (int i = 0; i < inArray.GetLength(0); i++)
       {
        
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum +=j;
        }
       }
    return sum;
    
}
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,]array = GetArray(row, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
AverageSum(array);
Console.WriteLine($"Среднее арифметическое:{AverageSum(array)}/{ int columns}");
