void Task41()
{
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

    Console.WriteLine("Сколько чисел нужно ввести?");
    int count = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Начинаем ввод...");
    int numbersBiggerThenNull = 0;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Введите новое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) numbersBiggerThenNull++;
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine($"Чисел больше нуля {numbersBiggerThenNull}");
}

void Task43()
{
// Задача 43. Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Random rand = new Random();
int k1 = rand.Next(-6,6);
int b1 = rand.Next(-6,6);
int k2 = rand.Next(-6,6);
int b2 = rand.Next(-6,6);
int x;
int y;
Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");
    if(k1 != k2)
    {
        x = (b2 - b1)/(k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Тестовый y = {k2 * x + b2}");
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
    }
}

Task41();
Task43();