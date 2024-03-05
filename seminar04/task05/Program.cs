// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных 
// чисел в массиве.

int[] RandomMas(int num)
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 1000);
    }
    return mas;
}

void PrintMas(int[] mas)
{
    foreach (var i in mas)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
} 

int Count (int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            Console.Write($"{mas[i]} ");
            count++;
        }
    }
    Console.WriteLine();
    return count;
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrey = RandomMas(n);
PrintMas(arrey);
Console.Write(Count(arrey));
