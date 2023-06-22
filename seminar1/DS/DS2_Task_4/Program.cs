// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третие число:");
int c = Convert.ToInt32(Console.ReadLine());
int max=a;

if(b>max){
    if(b>c){
        Console.Write($"Число {b} самое большое");
    }
}
if(c>a){
    Console.Write($"Число {c} самое большое");
    }
    else{
        Console.Write($"Число {a} самое большое");
    }