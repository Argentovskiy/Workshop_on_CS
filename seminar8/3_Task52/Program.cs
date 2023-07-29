// Задача 52: Задайте двумерный массив из целых чисел.
 // Определить столбец с наименьшей суммой элементов

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

int GetMinColumFromArray(int[,] array)
{
    int min=int.MaxValue, resultColum=0;
     for (int i = 0; i < array.GetLength(1); i++)
    {
        // Обход столбца
        int tempSum=0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            tempSum=tempSum+array[j,i];
        }
        if(tempSum<min)
        {
            min=tempSum;
            resultColum=i;
        }
      
    }
  return resultColum;
}
 // ============================
 int[,] array = GetDoubleArray(3,4);
 PrintDoubleArray(array);
 Console.WriteLine($"Номер столбца с наименьшей суммой: {GetMinColumFromArray(array)}");


