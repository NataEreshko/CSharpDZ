// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int allSumDigit(int n, int m = 0) 
{
	int sum = 0;
	int m2 = m > 0 ? m : m + 1;
	if (n >= m && n > 0) {
		sum += n + allSumDigit(n - 1, m);
		return sum;
	}
	return sum;
}

int n, m;
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine(), out n) ;
Console.Write("Введите число M: ");
int.TryParse(Console.ReadLine(), out m) ;

Console.WriteLine($"M = {m}; N = {n} -> {allSumDigit(n, m)}");
