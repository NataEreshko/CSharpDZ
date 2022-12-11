// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] createMas(int size, int min, int max)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
        mas[i] = new Random().Next(min, max);
    return mas;
}


int n = 15;
int[] mas = createMas(n, 1, 20);


int sum = 0;

for(int i = 0; i < mas.Length; i++) {
    if (i % 2 == 1)
        sum += mas[i];    
}
Console.WriteLine($"[{string.Join(", ", mas)}] -> {sum}");