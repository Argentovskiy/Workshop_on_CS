// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// a=10
// b = 8
// c=14
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третие число:");
int c = int.Parse(Console.ReadLine());
int max=a;

if(b>max){
    if(b>c){
        Console.Write($"Число {b} самое большое");
    }
    if(c>a){
    Console.Write($"Число {c} самое большое");
    }
    }
    else{
        Console.Write($"Число {a} самое большое");
    }