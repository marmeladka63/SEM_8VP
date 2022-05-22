// заменить элементы внутри массива, при этом проверив а можно ли сделать такую замену - строки на столбцы,столбцы на строки.

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
PrintArray(TutnArray(array));


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

/*void TurnArray(int[,] array)
{
    int temp = 0;

    {
        if (array.GetLength(0) == array.GetLength(1))
        {
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {

                    for (int j = 0; j < i; j++)
                    {
                        temp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = temp;
                    }
                }


            }
        }
    }
}
*/

// Решение через транспонирование матрицы

int[,] TutnArray(int[,] array)
{
    int[,] newArray= new int[array.GetLength(1),array.GetLength(0)];
     for (int i = 0; i < newArray.GetLength(0); i++)
                {

                    for (int j = 0; j < newArray.GetLength(1); j++)
                    {
                       newArray[i,j]=array[j,i];
                    }
} return newArray;
}