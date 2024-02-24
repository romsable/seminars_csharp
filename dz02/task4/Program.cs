 
 using System; 
 
class Program 
{ 
    static void Main() 
    { 
        Console.Write("Введите натуральное число N: "); 
        int number = int.Parse(Console.ReadLine()); 
 
        if (number < 0) 
        { 
            Console.WriteLine("Введено отрицательное число. Пожалуйста, введите натуральное число."); 
            return; 
        } 
 
        Console.Write("Цифры числа через запятую: "); 
        DisplayDigits(number); 
    } 
 
    static void DisplayDigits(int n) 
    { 
        string digits = n.ToString(); 
 
        for (int i = 0; i < digits.Length; i++) 
        { 
            Console.Write(digits[i]); 
 
            // Добавляем запятую, если это не последняя цифра 
            if (i < digits.Length - 1) 
            { 
                Console.Write(", "); 
            } 
        } 
 
        Console.WriteLine(); 
    } 
}