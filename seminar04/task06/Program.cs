// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним 
// и т.д.)

using System.ComponentModel;

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

int[] FlipMas(int[] mas)
{
    int t;
    int l = mas.Length - 1;

    for (int i = 0; i < mas.Length / 2; i++)
    {
        t = mas[i];
        mas[i] = mas[l];
        mas[l] = t;
        l--;
    }
    return mas;
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrey = RandomMas(n);
PrintMas(arrey);
FlipMas(arrey);
PrintMas(arrey);