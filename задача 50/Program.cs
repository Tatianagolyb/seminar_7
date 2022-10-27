// Напишите программу, которая на вход принимает число и возвращает индексы элемента в двумерном массиве или же указание, что такого элемента нет.
int[,] GetArray(int m, int n, int a, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    {
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                result[i, j] = new Random().Next(minValue, maxValue + 1);

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
void GetValue(int[,] inArray);
{
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (index > i && index > j);
        }
                Console.WriteLine("такого числа нет");
        {
              
            if (index==i|| index=j)
            GetValue(i, j);
        }
            Console.WriteLine(inArray.GetValue(i, j));
        }
        
    }


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int[,] array=GetValue(a,0,10);
GetValue(array);
Console.WriteLine($"Индекс элемента в массиве {GetValue(array)} ");




