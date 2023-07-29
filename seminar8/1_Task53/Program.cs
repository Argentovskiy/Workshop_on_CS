// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
// генерация двумерного масива
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

// Меняем первую с последней строки
int[,] swapArray(int[,] array)
{
    int tempSwap=0;
for (int i = 0; i < array.GetLength(1); i++)
{
    tempSwap=array[0,i];
    array[0,i]=array[array.GetLength(0)-1,i];
    array[array.GetLength(0)-1,i]=tempSwap;
}
return array;
}


// ============================
 int[,] array = GetDoubleArray(3,4);
 PrintDoubleArray(array);
System.Console.WriteLine();
 int[,] array2=swapArray(array);
 PrintDoubleArray(array2);