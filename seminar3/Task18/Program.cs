// Задача №18. Работа в группах
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
 
void GetArea(int x){
        if(x==1)
        {
           Console.WriteLine("Четверть 1: x>0 && y>0 ");
        }
           if(x==2)
        {
            Console.WriteLine("Четверть 2: x<0 && y>0 ");
        }
           if(x==3)
        {
            Console.WriteLine("Четверть 3: x<0 && y<0 ");
        }
           if(x==4)
        {
            Console.WriteLine("Четверть 4: x>0 && y<0 ");
        }
}

//==================================================

Console.WriteLine("Введите вашь номер четверти: ");
int x=int.Parse(Console.ReadLine());


if(x<0 || x>4){
    Console.WriteLine("Неверная четверть! ");
}
else{
    GetArea(x);
}
