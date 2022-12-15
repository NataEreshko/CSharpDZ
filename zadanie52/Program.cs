//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int m = new Random().Next(1,10), n = new Random().Next(1,10);
int[][] mas = new int[n][];

for(int i = 0; i < n; i++) {
    mas[i] = new int[m];
    for(int j = 0; j < m; j++)
        mas[i][j] = new Random().Next(0, 20);
}

Console.WriteLine($"m = {m}, n = {n}");


for (int i = 0; i < n; i++) {
    Console.WriteLine($"{string.Join(", ", mas[i])}");
}

float[] sr = new float[m];

for (int i = 0; i < m; i++) {
    sr[i] = 0;
    for (int j = 0; j < n; j++)
        sr[i] += mas[j][i];
    sr[i] /= n;    
}



Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join(", ", sr)}.");

