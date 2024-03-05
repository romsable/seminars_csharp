// Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System.Linq.Expressions;

bool sumnumber (int n)
{
    string m = Convert.ToString(n);
    Console.WriteLine(m);
    int sum = 0;
    foreach (var item in m)
    {
       if (char.IsDigit(item))
       {
        int digit = item - '0';
        sum += digit;
       }
    }
    Console.WriteLine(sum);
if (sum % 2 == 0) return true;
return false;
}

while (true)
{
    Console.Write("Введите целое число (или символ q для выхода): ");
     string input = Console.ReadLine();
     int number;
    if (input == "q")
    {
        break;
    }
    int.TryParse(input, out number);
   if ( sumnumber(number))
    {
        break;
    }
    else
    {
        continue;
    }
}
