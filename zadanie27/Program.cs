// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int calc(string? num)
{
    int sum = 0;
    if (num == null)
        return sum;
    
    for (int i = 0; i < num.Length; i++)
        sum += int.Parse(num[i].ToString());    
    return sum;
}

Console.Write("Введите число: ");
string? num = Console.ReadLine();

Console.WriteLine($"{num} -> {calc(num)}");