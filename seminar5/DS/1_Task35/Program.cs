// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задаем массив рандомными числами.
int[] RandomArray(int quantity){
    int[] array =new int[quantity];
    Random rand = new Random();

    for(int i=0; i<quantity; i++){
        array[i]=rand.Next(100,1000);
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
// Поиск количества положительных чисел в массиве.
int PlusNumber(int[] Array)
{   int Plus=0;
    for(int i=0; i<Array.Length; i++) if(Array[i]%2==0) Plus++;
    return Plus;
}

System.Console.WriteLine("Введите количество элементов в массиве: ");
int N=int.Parse(Console.ReadLine());
int[] Mas = new int[N];
Mas=RandomArray(N);

System.Console.WriteLine($"Вашь масив и количество положительных чисел ->: ");
PrintArrya(Mas);
System.Console.WriteLine($"->{PlusNumber(Mas)}");

//Готово