﻿// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.

Console.Write("Введите трехзначное целое число: ");
int num = int.Parse(Console.ReadLine());
int num1 = num%10;
int num2 = num/100;
Console.Write($"сумма числа {num2} и {num1} равна {num1+num2}");

