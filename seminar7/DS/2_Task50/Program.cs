// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            System.Console.Write(" "+newArray[i,j]+" ");
        }
        System.Console.WriteLine();
    }
    return newArray;
}

// ==============================================================
System.Console.Write(" Введите количество строк m : ");
int m=int.Parse(Console.ReadLine());

System.Console.Write(" Введите количество столбцов n :");
int n=int.Parse(Console.ReadLine());

System.Console.WriteLine("Масив заполненный случайнымичислами:");
int [,] randomArray = DoRundomArray(m,n);

System.Console.WriteLine("Введите позиции вашего элемента:");
System.Console.Write("Строка номер:");
int a=int.Parse(Console.ReadLine())-1;
System.Console.Write("Столбец номер:");
int b=int.Parse(Console.ReadLine())-1;
if(a<=m && b<=n) System.Console.WriteLine("Вашь элемент: "+randomArray[a,b]);
else System.Console.WriteLine("-> такого числа в массиве нет");

// Готово
