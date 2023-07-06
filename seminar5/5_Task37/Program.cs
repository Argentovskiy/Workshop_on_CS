// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21




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

int[] GetIncrease(int[] mas) {
    int Sum=0,size=mas.Length;
    if(size%2 == 0) size=mas.Length/2;
    else size=mas.Length/2+1;
    int[] Inc = new int[size];
    for(int i=0; i<mas.Length/2; i++){
                else Inc[i]=mas[i]*mas[mas.Length-1-i];
    }
    // Добавить условие для середины
    //if(i==mas.Length/2) Inc[i]=mas[i];
    return Inc;
}

//=====================================
System.Console.WriteLine("Введите количество элементов в массиве:");
int N=int.Parse(Console.ReadLine());
int[] Array1 = RandomArray(N);
System.Console.WriteLine("Нашь массив: ");
PrintArrya(Array1);
System.Console.WriteLine();
PrintArrya(GetIncrease(Array1));