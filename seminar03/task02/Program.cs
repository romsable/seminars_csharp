// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, а положительные на отрицательные.

// Пример

// [1 -5 6]

// => [-1 5 -6]

int[] Random_mas(int[] ran)
{
    for (int i = 0; i < ran.Length; i++)
    {
        ran[i] = new Random().Next(-10, 10);
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

int[] mas = new int[10];
Random_mas(mas);

PrintArray(mas);

for (int i = 0; i < mas.Length; i++)
{

    if (mas[i] != 0)
    {
        mas[i] = mas[i] * -1;
    }

}

PrintArray(mas);