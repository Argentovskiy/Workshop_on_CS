// Задача 4:
// Даны два положительных целых числа, представленных в виде строк. Необходимо получить сумму чисел, 
// которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.

// Для решения этой задачи запрещено преобразовывать входные строки сразу напрямую в целое число при 
// помощи встроенной функции. Необходимо сделать это самостоятельно.

// Пример 1:
// Входные значения: num1 = "11", num2 = "123"
// Результат: "134"

// Пример 2:
// Входные значения: num1="456", num2 = "77"
// Результат: "533"

// Пример 3:
// Входные значения: num1 = "0", num2 = "0"
// Результат: "0"



// функция для преоброзованя строки в число
int stringToNumber(string num)
{
    var result=0;
    for (int i = 0; i < num.Length; i++)
    {
        result=result*10+(int)char.GetNumericValue(num[i]);
    }
    return result;
}
// конвертируем числа в строку
string NumbToStr(int num)
{
    
    if((num/10)==0) return $"{num}";
    string result=$"{NumbToStr(num/10)+num%10}";
    return result;
}

//==================================
string num1="456";
string num2="77";
System.Console.WriteLine(num1);
System.Console.WriteLine(num2);
var sum=stringToNumber(num1)+stringToNumber(num2);
System.Console.WriteLine(NumbToStr(sum));


// Готово