// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void allDigit(int n, int m = 0) 
{
	int m2 = m > 0 ? m : m + 1;
	if (n >= m && n > 0) {
		Console.Write(n);
		if (n > m2) {
			Console.Write(", ");
		}
		allDigit(n - 1, m);
		return;
	}
	Console.WriteLine("");

}

Console.Write("Введите число N: ");

int n;
int.TryParse(Console.ReadLine(), out n) ;
allDigit(n, 5);