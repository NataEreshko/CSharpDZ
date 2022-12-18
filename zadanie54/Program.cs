// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void printMass(in int[][] mas)
{
    Console.WriteLine(string.Concat(System.Linq.Enumerable.Repeat("*", mas[0].Length * 3)));
    for(int i = 0; i < mas.Length; i++)
        Console.WriteLine($"{string.Join(", ", mas[i])}");
}

void sortMas(int[] mas)
{
    bool isSorted;
    int tmp;

    do {
        isSorted = true;    
        for (int i = 0; i < mas.Length - 1; i++) {
            if (mas[i] < mas[i + 1]) {
                tmp = mas[i]; mas[i] = mas[i + 1]; mas[i + 1] = tmp;
                isSorted = false;
            }
        }
    } while(!isSorted);
}
int[][] mas = genMas();

printMass(mas);
for (int i = 0; i < mas.Length; i++) {
    sortMas(mas[i]);
}
printMass(mas);
