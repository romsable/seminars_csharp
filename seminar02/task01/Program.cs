// Напишите программу, которая принимает на вход 
// трёхзначное число и удаляет вторую цифру этого числа.

// int number = new Random().Next(100,1000);
// Console.WriteLine(number);
// int s = number/100*10 + number%10;
// Console.WriteLine(s);
// Console.WriteLine(number/100 + "" + number%10);


// Напишите программу, которая принимает на вход 
// трёхзначное число и возводит вторую цифру этого 
// числа в степень, равную третьей цифре.

// int number = new Random().Next(10,1000);
// Console.WriteLine(number);
// if(number <= 999 && number >= 100)
// {
//     Console.WriteLine(Math.Pow(number/10%10, number%10));
// }
// else 
// {
//     Console.WriteLine("Число не трехзначное");
// }


// Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2%num1==0)
// {
//     Console.WriteLine("второе число кратно первому");
// }
// else 
// {
//     Console.WriteLine(num2%num1);
// }


// Напишите программу, которая выводит третью слева цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num<100)
{
    Console.WriteLine("третьего числа нет");
}
else
{
    while (num >= 1000)
{
    num /= 10; //num = num / 10
}
Console.WriteLine(num%10);
}