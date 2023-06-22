// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите ваш день недели:");
int a = Convert.ToInt32(Console.ReadLine());


if(a==1){
    Console.Write("Вашь день ПОНЕДЕЛЬНИК!");
}
else if(a==2){
    Console.Write("Вашь день ВТОРНИК!");
}
else if(a==3){
    Console.Write("Вашь день СРЕДА!");
}
else if(a==4){
    Console.Write("Вашь день ЧЕТВЕРГ!");
}
else if(a==5){
    Console.Write("Вашь день ПЯТНИЦА!");
}
else if(a==6){
    Console.Write("Вашь день СУББОТА!");
}
else if(a==7){
    Console.Write("Вашь день ВОСКРЕСЕНЬЕ!");
}
else{
    Console.Write("Нет такого дня недели!");
}