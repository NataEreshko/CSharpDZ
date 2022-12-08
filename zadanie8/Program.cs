// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Write("Введите число N: ");
int n;
int.TryParse(Console.ReadLine(), out n);

for (int i = 0; i < n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
