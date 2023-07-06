// Задача 25: Напишите программу, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int power(int a, int b){
    int c=1;
    for(int i=1; i<=b; i++){
        c=c*a;
    }
    return c;
}

System.Console.WriteLine("Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

System.Console.WriteLine("Введите число А");
int A=int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число B");
int B=int.Parse(Console.ReadLine());

System.Console.WriteLine($"число {A} в натуральную степень {B} = {power(A,B)}");
