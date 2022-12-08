// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a, b;

Console.Write("Введите число a = ");
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите число b = "); 
int.TryParse(Console.ReadLine(), out b);

if (a > b)
    Console.WriteLine($"Число a({a}) > b({b}) ");

if (a < b)
    Console.WriteLine($"Число b({b}) > a({a}) ");

if (a == b)
    Console.WriteLine($"Числа одинаковые b({b}) == a({a}) ");
