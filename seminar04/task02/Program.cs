// Задайте массив из N случайных целых чисел 
// (N вводится с клавиатуры).

// Найдите количество чисел, которые оканчиваются 
// на 1 и делятся нацело на 7.

// Пример

// [1 5 11 21 81 4 0 91 2 3]

// => 2


int[] RandomMas(int num)
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(19, 22);
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
        if (mas[i] % 10 == 1 && mas[i] % 7 == 0)
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
Console.WriteLine(Count(arrey));