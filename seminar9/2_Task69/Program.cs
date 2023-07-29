// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


//Возводим число в степень
int Pow(int a, int b)
{
    int c=a;
    if(b==1) return a;
    b--;
    c=a*Pow(a,b);
    return c;
}


//======
System.Console.WriteLine("Введите число А: ");

int A =int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");

int B =int.Parse(Console.ReadLine());

System.Console.WriteLine(" -> "+Pow(A,B));
