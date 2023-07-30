// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


//Сумма чисел
int SumNumber(int n)
{
    if((n/10)==0) return n;
    int sum=0;
    sum=SumNumber(n/10)+n%10;
    return sum;
}


//======
System.Console.WriteLine("Введите число сумму чисел которого нужно посчитать: ");

int number =int.Parse(Console.ReadLine());

System.Console.WriteLine(SumNumber(number));