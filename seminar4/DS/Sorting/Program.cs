// Задача отсортировать массив по возрастанию.

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
// Сортировка, наверное называется линейная.
int[] IntSorting(int[] array){
    int count=0;
    for(int i=0; i<array.Length; i++){
         for(int j=i+1; j<array.Length; j++){
            if(array[j]<array[i]){
                count=array[i];
                array[i]=array[j];
                array[j]=count;
                j=i;
            }
        }
    }
    return array;
}

Console.WriteLine("программа сортирует массив по возростанию:");
int N=10;
int[] Array=RandomArray(10);
PrintArrya(Array);
System.Console.WriteLine();
System.Console.WriteLine("Отсортированный массив: ");
PrintArrya(IntSorting(Array));


// Готово.