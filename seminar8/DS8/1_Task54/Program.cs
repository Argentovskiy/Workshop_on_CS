// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.


 int[,] GetDoubleArray(int countRow, int countColumn)
 {
    int[,] array = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i,j] = new Random().Next(-99,99);
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
            Console.Write(string.Format("{0,8}",array[i,j]));
        }
        System.Console.WriteLine();
    }
 }

// Сортировка строки двумерного масива
int[,] BubbleSort(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(j+1<array.GetLength(1) && array[i,j] < array[i,j + 1])
					{
						int t=array[i,j+1];
						array[i,j+1]=array[i,j];
						array[i,j]=t;
                        j=0;
                    }
    }
}
return array;
}


// ============================
 int[,] array = GetDoubleArray(5,5);
 PrintDoubleArray(array);
System.Console.WriteLine("Массив с отсортированными по убыванию строками: ");

 int[,] array2 =BubbleSort(array);
 PrintDoubleArray(array2);

 // Готово