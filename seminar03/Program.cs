// решение задачи 4 из дз

Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
int count = 0;
while (m > 0)
{
    count++;
    m /= 10;
}
while (count > 0)
{
    Console.Write($"{n / Convert.ToInt32(Math.Pow(10, count-1))%10}, ");
    count--;
} 