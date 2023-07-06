//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// Задаем массив рандомными числами.
int[] RandomArray(int quantity){
    int[] array =new int[quantity];
    Random rand = new Random();

    for(int i=0; i<quantity; i++){
        array[i]=rand.Next(-9, 10);
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

int FaindCount(int[] mas){
    int count =0;
    for(int i=0; i<mas.Length; i++){
        if
    }
}
//===============================================================================
int[] arrayMas =new int [12];
arrayMas=RandomArray(12);

System.Console.WriteLine("нашь массив: ");
PrintArrya(arrayMas);


///////////////////////////////////////////////
int Number =BeFaind(N, arrayMas);
System.Console.WriteLine();
if(Number==-1){System.Console.WriteLine("Вашего элементанет в этом массиве!");}
else{System.Console.WriteLine($"Вашь элемент находится под номером: {Number+1}");}
System.Console.WriteLine(arrayMas[Number]);
// Готово.