// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void palindrome (int n){
    string s=n.ToString();
    int i=0,lin=s.Length;
        while(i<(lin/2)){
        if(s[i] == s[lin-i-1]){
            i++;
        }
        else{
            Console.WriteLine(" нет ");
            break;
        }
    }
    if(i>lin/2-1){
        Console.WriteLine("Yes");
    }
}

Console.WriteLine("Введите ваше пятизначное число : ");
int N=int.Parse(Console.ReadLine());
if(N<0){ N=-N;}
if(N<100000){ palindrome(N); }
    else{ Console.WriteLine("Вы ввели неверние число!"); }

// Готово