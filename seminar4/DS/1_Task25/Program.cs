// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// ??? Понял задачу так что заданные числа в примере нужно вести прямо в програме. 
// Для удобства написал код ввода с консоли.

//=== Удаляем запятые ====
int[] dell (string a){
char b = ',';
int[] array= new int[100];
int j=0;
int tt=0,td;
//string temp=string.Empty;
for(int i=0; i<a.Length-1; i++){
      if(a[i] == b) {  
        tt=0;
        for(int n=0; n<i; n++){ td=tt*10; tt=td+a[n];
        System.Console.WriteLine($"td= {td}");
        System.Console.WriteLine($"a= {a[n]}"); }
        System.Console.WriteLine($"tt= {tt}");
                array[j]=tt/10;
        //System.Console.WriteLine($"tt= {tt}");
        a=a.Remove(0,i+1);
        System.Console.WriteLine(a);
        System.Console.WriteLine($"элемент {j} = {array[j]} ");
        j++;
        i=0;
    }
}
return array;
}

void PrintArrya(int[] array){
    for(int i=0; i<array.Length;i++){
        System.Console.Write($" {array[i]}");
    }
}

Console.WriteLine("Введите через запятую вашь массив");

string strA=Console.ReadLine();
//int[] arrayB =dell(strA);

PrintArrya(dell(strA));
//int[] array=new int[4];
