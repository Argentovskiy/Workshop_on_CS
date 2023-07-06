// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumOfNumbers(int a){
    int sum=0;
    while(a>0){
        sum=sum+a%10;
        a=a/10;
    }
    return sum;
}
System.Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе.");
System.Console.WriteLine("Введите ваше число:");
int A=int.Parse(Console.ReadLine());
System.Console.WriteLine($"сумма цифр в числе {A} : {SumOfNumbers(A)}");

// Го