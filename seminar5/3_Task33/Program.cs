// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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
//========================================
int[] arrayMas =new int [8];
arrayMas=RandomArray(8);

System.Console.WriteLine("нашь массив: ");
PrintArrya(arrayMas);

System.Console.WriteLine("Введите искомое число: ");
int N=int.Parse(Console.ReadLine());
arrayMas=IntSorting(arrayMas);
int Number =BeFaind(N, arrayMas);
System.Console.WriteLine();
if(Number==-1){System.Console.WriteLine("Вашего элементанет в этом массиве!");}
else{System.Console.WriteLine($"Вашь элемент находится под номером: {Number+1}");}
System.Console.WriteLine(arrayMas[Number]);
// Готово.