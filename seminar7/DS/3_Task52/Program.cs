// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Заполняем масив случайными числами
int [,] DoRundomArray(int m, int n)
{
    int [,] newArray = new int[m,n];
    Random random=new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j]=random.Next(1,10);
            System.Console.Write("  "+newArray[i,j]+"  ");
        }
        System.Console.WriteLine();
    }
    return newArray;
}

// Метод для подсчета среднгего арифмитического столбцов
void sumPost(int[,] array)
{
    double sum=0,arithmean=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[j,i];
        }
        arithmean=sum/array.GetLength(1);
        System.Console.Write(" "+Math.Round(arithmean,1)+"  ");
        sum=0;
    }
}
//=================================================================
int m=4, n=4;
int[,] DoArray = DoRundomArray(m,n);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
sumPost(DoArray);

// Готово.
