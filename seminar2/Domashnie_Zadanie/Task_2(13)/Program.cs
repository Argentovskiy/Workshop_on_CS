// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if(a<0){ a=a*(-1);} //  a=-a; проверка числа на отрицательность.
//int res=-1;
//while(a>99){
//    res=a%10;
//    a=a/10;
//    }
//if(res==-1){ Console.WriteLine($"В числе {a} третьей цифры нет.");  }
//else{ Console.WriteLine(res); }

if(a>99){
string st=a.ToString();
Console.WriteLine(st[2]);
}else {Console.WriteLine($"В числе {a} третьей цифры нет.");}

// Готово!
// На семинаре переделал под работу со строками.