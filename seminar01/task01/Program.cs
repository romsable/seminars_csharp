// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

// if(number1 == number2 * number2)
// {
//     Console.WriteLine("да");
// }  
// else
// {
//     Console.WriteLine("нет");
// }

if(number1 == Math.Pow(number2,2))
{
    Console.WriteLine($"квадрат числа {number2} равен {number1}");
}  
else
{
    Console.WriteLine("квадрат числа {1} не равен {0}", number1, number2);
}
