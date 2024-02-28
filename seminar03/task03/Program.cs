// Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив. 

// Пример 

// [1 3 2 4 2 3] => [3 6 8] 
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

using System.Globalization;

int[] Random_mas(int[] ran)
{
    for (int i = 0; i < ran.Length; i++)
    {
        ran[i] = new Random().Next(1, 10);
    }
    return ran;
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] array_2 = new int[n / 2];
int i = 0;
int j = 0;
int l = array.Length - 1;
int m;
Random_mas(array);
PrintArray(array);

while (i < array.Length / 2)
{
    m = array[i] * array[l];
    array_2[j] = m;
    j++;
    i++;
    l--;
}
PrintArray(array_2);
if (i == l) Console.Write($"Элемент {array[i]} не имеет пары");
