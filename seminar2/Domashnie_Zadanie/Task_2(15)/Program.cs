﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите вашь день недели: ");
int a = int.Parse(Console.ReadLine());

if(a>99 && a<1000){
int res=a/10;
res=res%10;
Console.WriteLine($"Вторая цифра числа {a} = {res}");
}
else{
    Console.WriteLine("К сожалению вы ввели не трехзначное число!:");
}