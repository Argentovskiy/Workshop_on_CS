// Программа 5
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int b;
int a = Convert.ToInt32(Console.ReadLine());

b = -a;
while(b <= a){
    Console.WriteLine(b);
    b++;
}