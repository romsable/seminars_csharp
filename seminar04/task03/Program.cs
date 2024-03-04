// Заполните массив на N (вводится с консоли, не более 8) 
// случайных целых чисел от 0 до 9.

// Сформируйте целое число, которое будет 
// состоять из цифр из массива. Старший разряд 
// числа находится на 0-м индексе, младший – на последнем.

// Пример

// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] RandomMas(int num)
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 10);
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

int num(int[] mas)
{
    int n = 0;
    foreach (var item in mas)
    {
        n = n * 10 + item;
    }
    return n;
}

Console.WriteLine("Введите размер массива (max 8): ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrey = RandomMas(n);
PrintMas(arrey);
Console.WriteLine(num(arrey));