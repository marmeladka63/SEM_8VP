// Поменять первую и последнюю строчку в массиве. Через новый массив или через этот массив.
using System;


//Console.Clear();


int[,] array=GetArray(4,4,0,10);
PrintArray(array);
Console.WriteLine();
ReplaceString(array);
PrintArray(array);


int[,] GetArray(int rows,int columns, int min, int max)
{
  int[,] result=new int[rows,columns];

        for(int i=0; i<rows; i++)
        {
            for(int j=0;j<columns;j++)
            {
                result[i,j]=new Random().Next(min,max);
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

void ReplaceString(int[,] array)
{
    int temp =0;
    for (int j=0; j<array.GetLength(1); j++)
    {
        temp=array[0,j];
        array[0,j]=array[array.GetLength(1)-1,j];
        array[array.GetLength(1)-1,j]=temp;
    }
}