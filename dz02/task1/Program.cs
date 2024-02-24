Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("число кратно");
}
else 
{
    Console.WriteLine("число не кратно");
}
