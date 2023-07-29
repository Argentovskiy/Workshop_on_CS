// адача 62: Заполните спирально массив 4 на 4.

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
// Заполняем масив по спирали
 int[,] GetDoubleArraySp(int n)
        {
        int s=1,m=n;
        int[,] array = new int[n,m];
        //Заполняем периметр массива по часовой стрелке.
        for (int y = 0; y < n; y++) {
            array[0,y] = s;
            s++;
        }
        for (int x = 1; x < m; x++) {
            array[x,n - 1] = s;
            s++;
        }
        for (int y = n - 2; y >= 0; y--) {
            array[m - 1,y] = s;
            s++;
        }
        for (int x = m - 2; x > 0; x--) {
            array[x,0] = s;
            s++;
        }
        
        //координаты ячейки, которую необходимо заполнить следующей.
        int c = 1;
        int d = 1;
         while (s < m * n)
          {
            //Движемся вправо.
            while (array[c,d + 1] == 0) {
                array[c,d] = s;
                s++;
                d++;
            }
 
            //Движемся вниз.
            while (array[c + 1,d] == 0) {
                array[c,d] = s;
                s++;
                c++;
            }
 
            //Движемся влево.
            while (array[c,d - 1] == 0) {
                array[c,d] = s;
                s++;
                d--;
            }
 
            //Движемся вверх.
            while (array[c - 1,d] == 0) {
                array[c,d] = s;
                s++;
                c--;
            }
        }
        //При данном решении в центре всегда остаётся незаполненная ячейка.
        //Убираем её при помощи следующего цикла.
        for (int x = 0; x < m; x++) {
            for (int y = 0; y < n; y++) {
                if (array[x,y] == 0) {
                    array[x,y] = s;
                }
            }
        }
        return array;
        }
// ============================
 int[,] array = GetDoubleArraySp(4);
 PrintDoubleArray(array);

 // Готово