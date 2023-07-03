// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

void Kol ( int n){
int kl=0;

while(n>0){
n=n/10;
kl++;
}

Console.WriteLine(kl);
}

Console.WriteLine("Введите ваше число : ");
int N=int.Parse(Console.ReadLine());
Kol(N);

