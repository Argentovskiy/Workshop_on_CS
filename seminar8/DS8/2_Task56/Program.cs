// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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
 
 // печать двумерного массива в консоль ( с суммой элементов строки)
 void PrintDoubleArray(int[,] array)
 {
    int sum=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,8}",array[i,j]));
            sum=sum+array[i,j];
        }
        Console.Write(" || сумма -> "+sum);
        sum=0;
        System.Console.WriteLine();
    }
 }

// находим строку с наименьшей суммой элементов
int SumArrayMin(int[,] array)
{
    int sum2=int.MaxValue,numbStr=0,sum=0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum=sum+array[i,j];
    }
    if(sum<sum2)
    {
        sum2=sum;
        numbStr=i;
        i=0;
        
    }
    sum=0;
}
return numbStr;
}


// ============================
 int[,] array = GetDoubleArray(5,5);
 PrintDoubleArray(array);
System.Console.WriteLine("номер строки с наименьшей суммой элементов: "+SumArrayMin(array));

 // Готово