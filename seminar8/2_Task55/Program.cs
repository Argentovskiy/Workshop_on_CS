// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

 int[,] GetDoubleArray(int countRow, int countColumn)
 {
    int[,] array = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i,j] = new Random().Next(1,6);
        }
    }
    return array;
 }
 
 // печать двумерного массива в консоль
 void PrintDoubleArray(int[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+" ");
        }
        System.Console.WriteLine();
    }
 }

// переворачиваем матрицу
int[,] swapArray(int[,] array)
{
    if(array.GetLength(0)!=array.GetLength(1))
    {
        System.Console.WriteLine("Incorrect data");
        Environment.Exit(0);
    }
    int[,] array2=new int[array.GetLength(0), array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array2[i,j]=array[j,i];
    }
    
}
return array2;
}


// ============================
 int[,] array = GetDoubleArray(5,5);
 PrintDoubleArray(array);
System.Console.WriteLine();
 int[,] array2=swapArray(array);
 PrintDoubleArray(array2);