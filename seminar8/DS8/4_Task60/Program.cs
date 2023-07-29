// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.


// Заполняем массив случайными неповторяющимеся элементами.
 int[,,] GetDoubleArray(int countRow, int countColumn, int count)
 {
    int[,,] array = new int[countRow, countColumn, count];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
           for (int k = 0; k < count; k++)
           {
            int numb = new Random().Next(9,99);
            if(contains(array,numb)) k--; 
            else array[i,j,k]=numb;

           }
        }
    }
    return array;
 }
 //Проверка масива на наличие элемента
 bool contains(int[,,] arr, int elem) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           for (int k = 0; k < arr.GetLength(3); k++)
           {
             if (arr[i,j,k] == elem) 
            {
                return true;
            }
            }
        }
    }
    return false;
  
}
 // печать двумерного массива в консоль
 void PrintDoubleArray(int[,,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k]);
            }
        }
        System.Console.WriteLine();
    }
 }


// ============================
 int[,,] array = GetDoubleArray(3,3,3);
 System.Console.WriteLine(array.GetLength(2));
 PrintDoubleArray(array);
 System.Console.WriteLine();
 
//  int[,] array2 =GetDoubleArray(2,3);
//  PrintDoubleArray(array2);

// System.Console.WriteLine("произведение двух матриц.");
//  int [,] array3 =MatrixMultiplication(array,array2);
//  PrintDoubleArray(array3);
 // Готово