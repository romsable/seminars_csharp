Console.WriteLine("введите число от 10 до 99");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/10;
int num2 = num%10;

if (num < 10 || num > 99)
{
    Console.WriteLine("введенное число не соответствует заданному диапазону");
}
else if (num1 > num2)
{
    Console.WriteLine(num1);
} 
else 
{
    Console.WriteLine(num2);
}



