// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomNumber= new Random().Next(99,1000);
Console.WriteLine($"Случайное число : {randomNumber}");
int firstDigit=randomNumber/100;
int secondDigit=randomNumber%10;
Console.WriteLine($"Наше число : {firstDigit}{secondDigit}");
