// Удалить строку и столбец где есть минимальный элемент таблицы

using System;


Console.Clear();
Console.Write("Введите число строк n=");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов m=");
int m = int.Parse(Console.ReadLine());

int[,] array = GetArray(n, m, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент находится ->{String.Join(" ", GetIndexMin(array))}");
Console.WriteLine();
PrintArray(GetResultArray(array,GetIndexMin(array)));



int[,] GetArray(int n, int m, int min, int max)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
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
// Массив со строками и столбцами  минимального числа в массиве

int[] GetIndexMin(int[,] inArray)
{
    int[] result = new int[] { 0, 0 };
    int min = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (min > inArray[i, j])
            {
                min = inArray[i, j];
                result[0] = i;
                result[1] = j;

            }
        }

    }
    return result;
}

// Новый массив без одной строик и одного столбца, где был найден мин элемент
int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (j == indexes[0]) continue;
                result[row, column] = inArray[i, j];
                column++;

            }
            column = 0;
            row++;
        }
    } return result;
}

