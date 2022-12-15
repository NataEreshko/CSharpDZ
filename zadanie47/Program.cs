// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m = new Random().Next(1,10), n = new Random().Next(1,10);
double[][] mas = new double[n][];

for(int i = 0; i < n; i++) {
    mas[i] = new double[m];
    for(int j = 0; j < m; j++)
        mas[i][j] = new Random().NextDouble();
}

Console.WriteLine($"m = {m}, n = {n}");
for(int i = 0; i < n; i++)
    Console.WriteLine($"{string.Join(", ", mas[i])}");