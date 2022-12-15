// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int m = new Random().Next(1,10), n = new Random().Next(1,10);
int[][] mas = new int[n][];

for(int i = 0; i < n; i++) {
    mas[i] = new int[m];
    for(int j = 0; j < m; j++)
        mas[i][j] = new Random().Next(0, 20);
}

Console.WriteLine($"m = {m}, n = {n}");
for(int i = 0; i < n; i++)
    Console.WriteLine($"{string.Join(", ", mas[i])}");
Console.Write("Введите координаты массива через запятую: ");
string? str = Console.ReadLine();
if (str != null) {
    string[] sAr =  str.Split(',', 2);
    int[] coords = new int[2];
    for (int i = 0; i < sAr.Length; i++ ) {
        coords[i] = int.Parse(sAr[i]);
    }
    if (coords[0] < 0 || coords[0] >= m || coords[1] < 0 || coords[1] >= n) {
        Console.WriteLine("такого числа в массиве нет");
    } else {
        Console.WriteLine($"[{coords[0]}, {coords[1]}] -> {mas[coords[1]][coords[0]]}");
    }
}