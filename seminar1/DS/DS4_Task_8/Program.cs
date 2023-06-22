// Программа 
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа:");
for (int i = 1; i <= a; i++)
{
    if(i%2 == 0){
    Console.WriteLine(i);
}

}
