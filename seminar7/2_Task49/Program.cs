// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
 // выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int countRow = 6;
System.Console.WriteLine(" количество строк : "+countRow);

int countColumn = 7;
System.Console.WriteLine("Введите количество столбцов: "+countColumn);

int [,] array = new int[countRow, countColumn];

for(int i=0; i<countRow; i++)
{
    int sum=0;
    for(int j=0; j<countColumn; j++)
    {
        array[i,j]=new Random().Next(1,11);
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

for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        if(i%2==0 && j%2==0) array[i,j]*=array[i,j];
    }
 }

for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        if(i%2==0 && j%2==0) Console.BackgroundColor= ConsoleColor.Blue;
        System.Console.Write(array[i,j]+" ");
        Console.BackgroundColor= 0;
        
    }
    System.Console.WriteLine();
}