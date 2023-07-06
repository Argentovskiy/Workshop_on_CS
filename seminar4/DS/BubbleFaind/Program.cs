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
// Сортировка
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
// Бинарный поиск.
int BeFaind(int fineNumber, int[] array){
    int left=0, right=array.Length-1,mid;
    while(left<=right){
        mid=left+(right-left)/2;
        if(array[mid]==fineNumber){ return mid; }
        else if(array[mid]<fineNumber){ left=mid+1;}
        else{ right=mid-1;}
    }
    return -1;
}

Console.WriteLine("программа находит элемент в массиве длиной N=10");
int N=10;
int[] Array=RandomArray(10);
PrintArrya(Array);
System.Console.WriteLine();
System.Console.WriteLine("Введите элемент который вы ищите:");
int FaindNumber=int.Parse(Console.ReadLine());
System.Console.WriteLine("Отсортированный массив: ");
Array=IntSorting(Array);
PrintArrya(Array);
System.Console.WriteLine();
if(BeFaind(FaindNumber, Array)==-1){System.Console.WriteLine("Вашего элементанет в этом массиве!");}
else{System.Console.WriteLine($"Вашь элемент находится под номером: {BeFaind(FaindNumber, Array)+1}");}
System.Console.WriteLine(Array[BeFaind(FaindNumber,Array)]);
// Готово.