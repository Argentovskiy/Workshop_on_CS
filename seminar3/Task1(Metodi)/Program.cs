//
//[Возвращаемый тип][Имя метода - глагол]([Параметр меторда])
//{
//    код метода
//  return .,..
//}
int a=-19;
a=Math.Abs(a);
Console.WriteLine(a);

int GetSum(int a, int b){
    int sum=a+b;
    return sum;
}
void PrintMassegeToConsole(string massege){
    Console.WriteLine(massege);
}
int mysum=a+150;
PrintMassegeToConsole(mysum.ToString());
Console.WriteLine(GetSum(a,b:150));