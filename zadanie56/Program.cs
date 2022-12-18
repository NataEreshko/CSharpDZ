// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[][] genMas()
{
    int m = new Random().Next(1,10), n = new Random().Next(1,10);
    int[][] mas = new int[n][];

    for(int i = 0; i < n; i++) {
        mas[i] = new int[m];
        for(int j = 0; j < m; j++)
            mas[i][j] = new Random().Next(0, 10);
    }

    Console.WriteLine($"m = {m}, n = {n}");
    return mas;
}

int sumMass(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++){
        sum += mas[i];
    }
    return sum;
}

void printMass(int[][] mas)
{
    Console.WriteLine(string.Concat(System.Linq.Enumerable.Repeat("*", mas[0].Length * 3)));
    for(int i = 0; i < mas.Length; i++) {
        Console.WriteLine($"{i + 1}: {string.Join(", ", mas[i])} = {sumMass(mas[i])}");
    }
}

int[][] mas = genMas();

printMass(mas);

int minRow = 0, minSum = sumMass(mas[0]);

for (int i = 1; i < mas.Length; i++) {
    int sumRow = sumMass(mas[i]);
    if (sumRow < minSum) {
        minSum = sumRow;
        minRow = i;
    }
}
minRow++;
Console.WriteLine($"Программа сосчитала сумму элементов в каждой строке и вывела номер строки с наименьшей суммой ({minSum}) элементов: {minRow} строка");