/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49 */

using System;


Console.Clear();
Console.Write("Введите число строк n=");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов m=");
int m = int.Parse(Console.ReadLine());

int[,] array = GetArray(n, m, 0, 10);
PrintArray(array);
Console.WriteLine();

int[,] newArray = GetArray(n, m, 0, 10);
PrintArray(newArray);
Console.WriteLine();

//PrintArray(MultArray);

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

//void MultArray(int[,] array, int[,]newArray);

int[,] result = new int[n, m];

 for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
           for (int k = 0; k < m; k++) 
           result[i,j]+=array[i,k]*newArray[k,j];

               Console.WriteLine($"{result[i,j]} ");

        } //return rezult;
    }

