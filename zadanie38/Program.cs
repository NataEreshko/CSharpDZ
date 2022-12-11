// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] createMas(int size)
{
    double[] mas = new double[size];
    for (int i = 0; i < size; i++)
        mas[i] = new Random().NextDouble();
    return mas;
}

int n = 8;
double[] mas = createMas(n);

double max, min ;
max = min = mas[0];


for (int i = 1; i < n; i++) {
    if (mas[i] > max) max = mas[i];
    if (mas[i] < min) min = mas[i];
}

Console.WriteLine($"[{string.Join(", ", mas)}] -> {max-min} ");

