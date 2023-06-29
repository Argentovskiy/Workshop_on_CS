// Задача 17 Пример

//Метод 
int GetAreaNumber(int x, int y){
        int NumberArea =0;
        if(x>0 && y>0)
        {
            NumberArea =1;
        }
           if(x<0 && y>0)
        {
            NumberArea =2;
        }
           if(x<0 && y<0)
        {
            NumberArea =3;
        }
           if(x>0 && y<0)
        {
            NumberArea =4;
        }
    return NumberArea;
}

//==================================================

Console.WriteLine("Введите координаты Х: ");
int x=int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y: ");
int y=int.Parse(Console.ReadLine());
int result1=0;
if(x==0 || y==0){
    Console.WriteLine("Координаты должны быть больше 0 ");
}
else{
    result1=GetAreaNumber(x,y);
}
Console.WriteLine($" Номер четверти вашей точки : {result1}");