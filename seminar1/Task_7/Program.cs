console.WriteLine("Введите трехзначное число: ");
a=int.Parse(Console.readline());
if(a>00 && a<1000){
b=a%10;
console.WriteLine($"Последняя цифра цисла = {b}");
}
else{
    console.WriteLine("Число неверное!");
}