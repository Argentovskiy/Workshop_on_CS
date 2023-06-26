// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

if((a*a==b)||(b*b==a)){
    Console.WriteLine("Yes!");
}
else{
    Console.WriteLine("No");
}