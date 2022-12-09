//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write($"Введите число: ");

int index;
string[] s = {"нет","нет","нет","нет","нет","да","да"};

int.TryParse(Console.ReadLine(), out index);
if (index < 1 || index > s.Length) {
    Console.WriteLine("выход из диапазона");
    return 1;
}

Console.WriteLine($"{index} -> {s[index-1]}");
return 0;