// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


//========================================================
System.Console.WriteLine("Сколько числе вы хотите ввести? ");
int M=int.Parse(Console.ReadLine());
int[] Array=new int[M];
int count=0;
System.Console.WriteLine($"Введите {M} чисел");
for (int i = 0; i < M; i++)
{
    Array[i]=int.Parse(Console.ReadLine());
    if(Array[i]>0) count++;
}
System.Console.WriteLine("чисел больше 0 -> "+count+"  ");

// готово