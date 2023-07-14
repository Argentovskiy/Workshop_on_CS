// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Заполняем двумерный масив случайными вещественными числами
double[,] RandomDouble(int m, int n)
{
    double[,] newArray = new double[m,n];
    Random rnd=new Random();
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newArray[i,j]=double.Round((rnd.Next(1,100)+rnd.NextDouble()),2);
            System.Console.Write(" "+newArray[i,j]+" ");
        }
        System.Console.WriteLine();
    }
    return newArray;
}

System.Console.Write(" Введите количество строк m : ");
int m=int.Parse(Console.ReadLine());
System.Console.Write(" Введите количество столбцов n :");
int n=int.Parse(Console.ReadLine());
System.Console.WriteLine("Масив заполненный случайнымичислами:");
double[,] randomArray = RandomDouble(m,n);

// Готово.