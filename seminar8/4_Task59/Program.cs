// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.

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

// Поиск наименьшего элемента массива
int[] findMinElement(int[,] array)
{
    int min=int.MaxValue;
    int[] minElement= new int[] {0,0};
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j]!=min)
                    {
                        if(array[i,j]<min)
                        {
                            min=array[i,j];
                            minElement[0]=i;
                            minElement[1]=j;
                        }
                    }
                }
    }
System.Console.WriteLine("Позиция наименьшего элемента: ["+ minElement[0]+" , "+ minElement[1]+"]" );
return minElement;
}
// Зануляем столбец и строку на пересечении с наименьшем элементом.
int[,] ZaroRawCol(int[,] array)
{
int[] minElem=findMinElement(array);
for (int i = 0; i < array.GetLength(0); i++) array[i,minElem[1]]=0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[minElem[0],i]=0;
    }
return array;
}


// ============================
 int[,] array = GetDoubleArray(5,5);
 PrintDoubleArray(array);
System.Console.WriteLine();

 int[,] array2=ZaroRawCol(array);
 PrintDoubleArray(array2);