// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] createMas(int size, int min, int max)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
        mas[i] = new Random().Next(min, max);
    return mas;
}

int n = 10;

int[] mas = createMas(n, 100, 1000); 

int count = 0;

for(int i = 0; i < mas.Length; i++) {
    if (mas[i] % 2 == 0)
        count++;    
}

Console.WriteLine($"[{string.Join(", ", mas)}] -> {count}");