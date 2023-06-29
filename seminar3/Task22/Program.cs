// Задача №22. Работа в группах
// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.

void Tablsqr (int n){
    int i=1;
    while(i<=n){
        Console.Write($"{Math.Pow(i,2)},");
        i++;
    }
}

Console.WriteLine("Введите ваше число N : ");
int N=int.Parse(Console.ReadLine());
Tablsqr(N);


