// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
string? num = Console.ReadLine();
if (num == null)
    return 1;

int sum = 0;
for (int i = 0; i < num.Length; i++)
    sum += int.Parse(num[i].ToString());

Console.WriteLine($"{num} -> {sum}");
return 0;