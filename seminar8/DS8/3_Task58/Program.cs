// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

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

    // метод для умножения матриц
    static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if ((matrixA.GetLength(1)) != (matrixB.GetLength(0)))
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (var i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }


// ============================
 int[,] array = GetDoubleArray(3,2);
 PrintDoubleArray(array);
 System.Console.WriteLine();
 
 int[,] array2 =GetDoubleArray(2,3);
 PrintDoubleArray(array2);

System.Console.WriteLine("произведение двух матриц.");
 int [,] array3 =MatrixMultiplication(array,array2);
 PrintDoubleArray(array3);
 // Готово