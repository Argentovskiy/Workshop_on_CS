// Задача №21. Работа в группах
//Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

double CalcDist(int x1, int x2, int y1, int y2 )
{
    double distance=Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return distance;
}

Console.WriteLine("Введите координаты точки A Х1: ");
int x1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты  Y1: ");
int y1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B  Х2: ");
int x2=int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты  Y2: ");
int y2=int.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между точками A B = {CalcDist(x1, x2, y1, y2)} ");

