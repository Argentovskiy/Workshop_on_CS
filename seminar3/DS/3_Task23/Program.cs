// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//  3 -> 1, 8, 27.
//  5 -> 1, 8, 27, 64, 125.

void Tablsqr (int n){
    int i=1;
    while(i<=n){
        if(i==n){Console.Write($" {Math.Pow(i,3)}.");}
        else{Console.Write($" {Math.Pow(i,3)},");}
        i++;
    }
}

Console.WriteLine("Введите ваше число N : ");
int N=int.Parse(Console.ReadLine());
Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");
Tablsqr(N);
// Готово