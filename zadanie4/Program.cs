// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a, b, c, max;

Console.Write("Введите число a = ");
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите число b = "); 
int.TryParse(Console.ReadLine(), out b);
Console.Write("Введите число c = "); 
int.TryParse(Console.ReadLine(), out c);

max = a;

if (max < b)
    max = b;

if (max < c)
    max = c;

Console.WriteLine($" max = {max}");


