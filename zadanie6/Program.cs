// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("введите число a = ");
int a;

int.TryParse(Console.ReadLine(), out a);

if (a % 2 == 0)
    Console.WriteLine($" a = {a} - чётное число");
else
    Console.WriteLine($" a = {a} - не чётное число");