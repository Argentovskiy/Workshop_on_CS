// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Заполняем масив случайными вещественными числами.
float[] RandomArray(int N)
{
    Random rnd=new Random();
    float[] Array = new float[N];
    for(int i=0; i<Array.Length; i++)
    {
         Array[i]=float.Round((rnd.Next(1,100)+(float)rnd.NextDouble()),2);
           
    }
    return Array;
}
// Вывод полученогомассива
void PrintArrya(float[] array){
    System.Console.Write("[");
    for(int i=0; i<array.Length;i++){
        if(i==array.Length-1){System.Console.Write($"{array[i]} ]");}
        else{System.Console.Write($"{array[i]} ");}
    }
}
// Находим  разницу межда максимальным иминимальным элементом.
float MinMax(float[] mas)
{
    float min=mas[0], max=mas[0];
    for(int i=0; i<mas.Length; i++)
    {
        if(mas[i]<min) min=mas[i];
        else if(mas[i]>max) max=mas[i];
    }
    System.Console.Write($" => {max} - {min} = {max-min}");
    return max-min;
}

int N=5;
float[] Mas = new float[N];
Mas=RandomArray(N);
PrintArrya(Mas);
MinMax(Mas);

// Готово