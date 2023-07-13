// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int countRow = 6;
System.Console.WriteLine(" количество строк : "+countRow);

int countColumn = 7;
System.Console.WriteLine("Введите количество столбцов: "+countColumn);

int [,] array = new int[countRow, countColumn];

for(int i=0; i<countRow; i++)
{
    
    for(int j=0; j<countColumn; j++)
    {
        array[i,j]=new Random().Next(1,11);
    }
}

int sum=0;

for(int i=0; i<array.GetLength(0); i++)
{   
    for(int j=0; j<array.GetLength(1); j++)
    {
        if(i==j) sum+=array[i,j];
    }
 }
System.Console.WriteLine();

for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        if(i==j) Console.BackgroundColor= ConsoleColor.Blue;
        System.Console.Write(" "+array[i,j]+" ");
        Console.BackgroundColor= 0;
        
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Сумма элементов диаганали = "+sum);