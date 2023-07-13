// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задаем массив рандомными числами.
int[] RandomArray(int quantity){
    int[] array =new int[quantity];
    Random rand = new Random();

    for(int i=0; i<quantity; i++){
        array[i]=rand.Next(-99,100);
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
int OddNumberSum(int[] Array)
{   int oddSum=0;
    for(int i=0; i<Array.Length; i++) if(i%2!=0) oddSum+=Array[i];
    return oddSum;
}

System.Console.WriteLine("Введите количество элементов в массиве: ");
int N=int.Parse(Console.ReadLine());
int[] Mas = new int[N];
Mas=RandomArray(N);

System.Console.WriteLine($"Вашь масив и количество положительных чисел ->: ");
PrintArrya(Mas);
System.Console.WriteLine($"->{OddNumberSum(Mas)}");

// Готово

