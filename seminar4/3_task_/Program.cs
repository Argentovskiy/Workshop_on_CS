// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] Array = new int [8];
int [] Sort(int[] array){
    int [] temp = new int [8];

    for(int i=0; i<array.Length; i++){
        for(int j=i+1; j<array.Length; j++){
            if(array[i]<array[j]) {
                temp[i]=array[j];
            }
        }
    }


}
int [] rnd(int[] array ){
    for(int i=0; i<array.Length; i++){
         array[i]=new Random().Next(0, 20);
         System.Console.WriteLine(array[i]);
    }
    return array;
    }


int[] Array2=rnd(Array);


//1. Орг-ть поиск в массиве.
//2. Бинарный поиск.


