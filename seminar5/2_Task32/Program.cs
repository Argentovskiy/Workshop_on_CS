// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот..
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
// Конвертируем элементы: положительные в отрицательные , а отрицательные в положительные
int[] ChangeNum(int[] mas){
    for(int i=0; i<mas.Length; i++) mas[i]*=-1;
    return mas;
    }

//========================================
int[] arrayMas =new int [8];
arrayMas=RandomArray(8);
System.Console.WriteLine("нашь массив: ");
PrintArrya(arrayMas);
arrayMas=ChangeNum(arrayMas);
System.Console.WriteLine();
PrintArrya(arrayMas);
System.Console.WriteLine();
