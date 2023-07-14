// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите переменные :");
System.Console.Write("b1=");
int b1=int.Parse(Console.ReadLine());
System.Console.Write("k1=");
int k1=int.Parse(Console.ReadLine());
System.Console.Write("b2=");
int b2=int.Parse(Console.ReadLine());
System.Console.Write("k2=");
double k2=int.Parse(Console.ReadLine());

if((k1 == k2) && (b1 == b2)) System.Console.WriteLine("Прямые совпадают");
else if (k1==k2)System.Console.WriteLine("Прямые параллельны");
else
    {
        double x=(b2-b1)/(k1-k2);
        double y=(k1*(b2-b1))/(k1-k2)+b1;
        System.Console.WriteLine("(x="+x+"; y="+y+")");

}

// Готово