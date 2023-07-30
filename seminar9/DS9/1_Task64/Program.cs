// Задача 1.
// Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
// Ваша задача вывести на экран максимальное количество следующих друг за другом 1.

// Пример 1:
// Исходный массив: [1, 1, 0, 1, 1, 1]
// Результат: 3
// Объяснение: в данном массиве две последовательности из 1: первые две единицы в самом начале и последние три единица в конце. Максимальное количество единиц в этих последовательностях 3.

// Пример 2:
// Исходный массив: [1, 0, 1, 1, 0, 1]
// Результат: 2

// Пример 3:
// Исходный массив: [1, 0, 1, 0, 0, 0, 1]
// Результат: 0
// Объяснение: в массиве нет следующих друг за другом единиц.

void printArray(int[] Array){
    System.Console.Write($"[");
for (int i = 0; i < Array.GetLength(0); i++)
{
    System.Console.Write(string.Format("{0,4}",Array[i]));
}
System.Console.WriteLine("  ]");
}

int CounterOne(int[] array)
{
    int counter=0,result=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i]==1) counter++;
        else if(counter>1)
        {
            result=counter;
            counter=0;
        }
        else counter=0;
    }
if(counter>1) result=counter;
return result;
}
//======================================

int [] array= new int[] {1, 0, 1, 0, 0, 0, 1};
printArray(array);
System.Console.WriteLine($"Результат: {CounterOne(array)}");

// Готово.