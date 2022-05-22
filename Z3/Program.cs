// Составить частотный словарь однотипных элементов массива 
// 1 встречается 2 раза
// 2 встречается 3 раза...

using System;


//Console.Clear();
Console.Write("Введите число строк n=");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов m=");
int m = int.Parse(Console.ReadLine());

int[,] array = GetArray(n, m, 0, 10);
PrintArray(array);
Console.WriteLine();
//TurnArray(array);
Console.Write(MultToString(array));


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


// Разворачиваем двумерный массив в одномерный

int [] MultToString(int[,] arr)
{
    int k=0;
    int[] newArray=new int[arr.Length];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArray[k]=arr[i,j];
            k++;
        }

} return newArray;
}
