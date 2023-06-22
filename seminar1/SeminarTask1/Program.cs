// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b){
    Console.Write($"Число {a} больше числа {b}");
}else{
    Console.Write($"Число {b} больше числа {a}");
}