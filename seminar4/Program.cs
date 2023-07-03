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
        if(s[i] == s[lin-i-1]){ i++; }
        else{
            Console.WriteLine(" нет ");
            break;
        }
    }
    if(i>lin/2-1){
        Console.WriteLine("Yes");
    }
}
//=====================================================
Console.WriteLine("Введите ваше пятизначное число : ");
int N=int.Parse(Console.ReadLine());
if(N<100000){ palindrome(N); }
    else{ Console.WriteLine("Вы ввели неверние число!"); }


// Готово



//if(PalindromeInt(N) == true) { Console.WriteLine("Yes it is");}
// bool PalindromeInt (int number)
// {
//     int rebmun = 0;
//     int meat = number;

//     while (meat > 0)
//     {
//         rebmun += meat % 10;
//         rebmun *= 10;
//         meat /=10;
//     }

//     rebmun /=10;

//     if (rebmun == number) return true;
//     else return false;
    
// }