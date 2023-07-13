// Среднее арифметическое каждого столбца.
// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Метод для подсчета среднего арифмитического.
void SumStolb(double sum, int kol)
{
    double Sumst=sum/kol;
    System.Console.Write($" {Math.Round(Sumst,1)} ");
}


int countRow = 3;
System.Console.WriteLine(" количество строк : "+countRow);

int countColumn = 4;
System.Console.WriteLine(" количество столбцов: "+countColumn);

int [,] array = new int[countRow, countColumn];

for(int i=0; i<countRow; i++)
{
    
    for(int j=0; j<countColumn; j++)
    {
        array[i,j]=new Random().Next(1,11);
    }
}

for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        
        System.Console.Write(" "+array[i,j]+"   ");
      
        
    }
    System.Console.WriteLine();
} 

double sum=0;
System.Console.WriteLine("Среднее арифметическое наших столбов:");
for(int i=0; i<array.GetLength(1); i++)
{
    for(int j=0; j<array.GetLength(0); j++)
    {
       //  System.Console.Write(" "+array[j,i]+" ");
        sum+=array[j,i];
        Console.BackgroundColor= ConsoleColor.Blue;
        Console.BackgroundColor= 0;
        
    }
    //System.Console.Write(" ср-е ар-кое: ");
    SumStolb(sum,array.GetLength(0));
    sum=0;
}

