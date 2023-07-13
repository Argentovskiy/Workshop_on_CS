// Задайте двумерный массив размером m*n , заполните случайными целыми числами 

System.Console.WriteLine("Введитте количество строк : ");
int countRow = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");

int countColumn = int.Parse(Console.ReadLine());

int [,] array = new int[countRow, countColumn];

for(int i=0; i<countRow; i++)
{
    int sum=0;
    for(int j=0; j<countColumn; j++)
    {
        array[i,j]=new Random().Next(1,11);

        sum+=array[i,j];
        System.Console.WriteLine("sum = "+sum+" ");
    }
}

for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        System.Console.Write(array[i,j]+" ");
    }
    System.Console.WriteLine();
}