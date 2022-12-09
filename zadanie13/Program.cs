// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine($"Введите число от 0 до {int.MaxValue}");

int num;
string s;

int.TryParse(Console.ReadLine(), out num);
Console.WriteLine($"Введено число {num}");
if (num < 100) {
    Console.WriteLine("Нет числа");
    return 1;
}
s = num.ToString();
Console.WriteLine($"Третья цифра заданного числа -> {s[2]}");
return 0;