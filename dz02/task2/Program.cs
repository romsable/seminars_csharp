using System.Security.Cryptography.X509Certificates;

Console.WriteLine("введите x");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > 0 && num2 > 0)
{
    Console.WriteLine("1 четверть");
}
else if (num1 < 0 && num2 > 0)
{
    Console.WriteLine("2 четверть");
}
else if (num1 < 0 && num2 < 0)
{
    Console.WriteLine("3 четверть");
}
else if (num1 > 0 && num2 < 0)
{
    Console.WriteLine("4 четверть");
}
else 
{
    Console.WriteLine("введено нулевое значение");
}