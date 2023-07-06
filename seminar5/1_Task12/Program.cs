// Задайте массив из 12 элементов, заполните их случайными числами
// Посчитайте сумму положительнфх и отрицательных элементов массива

// Задаем массив рандомными числами.
int[] RandomArray(int quantity){
    int[] array =new int[quantity];
    Random rand = new Random();

    for(int i=0; i<quantity; i++){
        array[i]=new Rundom().Next(-9,10);
    }
    return array; 
}

System.Console.WriteLine();

//Подсчет суммы положительных и отрицательных элементов
int[] Summs(int array)