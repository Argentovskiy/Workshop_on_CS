// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// 1 ??? Понял задачу так что заданные числа в примере нужно вести прямо в програме или задать рандомно. 
// 2 ??? В задинии массив из 8 элементов, но в примерах меньше. поэтому задал дополнительный ввод количества.


// Ввод массива через консоль
int[] ReadArray(int quantity){
    int[] array =new int[quantity];
    System.Console.WriteLine($"Введите {quantity} элементов массива:");
    for(int i=0; i<quantity; i++){
        array[i]=int.Parse(Console.ReadLine());
    }
    return array;

}

// Задаем массив рандомными числами.
int[] RandomArray(int quantity){
    int[] array =new int[quantity];
    Random rand = new Random();

    for(int i=0; i<quantity; i++){
        array[i]=rand.Next(100);
    }
    return array; 
}

// Вывод полученогомассива
void PrintArrya(int[] array){
    System.Console.Write("[");
    for(int i=0; i<array.Length;i++){
        if(i==array.Length-1){System.Console.Write($"{array[i]}]");}
        else{System.Console.Write($"{array[i]}, ");}
    }
}

Console.WriteLine("программа принимает количество элементов в массиве N, принивает значение склавиатуры или задает из рандом и выводит их на экран.");

System.Console.WriteLine("Введите количество элеменнов в массиве N:");
int N=int.Parse(Console.ReadLine());
System.Console.WriteLine("Хотите  ввести элементы массива в ручную ? (press Y)");
string click=Console.ReadLine();
if(click == "Y" || click == "y" || click == "Yes" || click == "yes"){ PrintArrya(ReadArray(N));}
    else{
        System.Console.WriteLine("Хорошо, мы запоним вашь масив сами!");
        PrintArrya(RandomArray(N));
        }


// Готово
