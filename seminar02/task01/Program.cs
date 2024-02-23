// Напишите программу, которая принимает на вход 
// трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100,1000);
Console.WriteLine(number);
int s = number/100*10 + number%10;
Console.WriteLine(s);
Console.WriteLine(number/100 + "" + number%10);