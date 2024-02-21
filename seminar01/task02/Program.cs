// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = - number;

while (index <= number)
{
    Console.Write($"{index} ");
     index++;
}  