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

int number = new Random().Next(10,1000);
Console.WriteLine(number);
if(number <= 999 && number >= 100)
{
    Console.WriteLine(Math.Pow(number/10%10, number%10));
}
else 
{
    Console.WriteLine("Число не трехзначное");
}