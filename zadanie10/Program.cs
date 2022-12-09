// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите 3-х значное число: ");
int result;
int.TryParse(Console.ReadLine(), out result);

if (100 > result || result >= 1000) {
    Console.WriteLine("Неверное число");
    return 1;

}
result -= result / 100 * 100;
result /= 10;
Console.WriteLine(result);
return 0;
