/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


using System;


Console.Clear();
Console.Write("Введите число строк n=");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов m=");
int m = int.Parse(Console.ReadLine());

int[,] array = GetArray(n, m, 0, 10);

PrintArray(array);
Console.WriteLine();



int[,] GetArray(int n, int m, int min, int max)
{
    int[,] result = new int[n, m];

    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result[i, j] = new Random().Next(min, max);
            }

        }
        if (n != m)
        {
            return result;
        }

        else
        { Console.WriteLine("Матрица не должна быть квадратной"); }


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


int[] sum = new int[array.GetLength(0)];

for (int i = 0; i < array.GetLength(0); i++)

    for (int j = 0; j < array.GetLength(1); j++)
    {

        sum[i] += array[i, j];
    }
    //int[] result=new int[]{0};
int min = sum[0];
int index=0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (min > sum[i])
    min=sum[i];
    index=i;
    
}
Console.Write($"мин сумма строки = {min} ");
Console.Write($"Номер строки с минимальной суммой = {index} ");







