// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[][] genMas(int m, int n)
{
    int[][] mas = new int[n][];

    for(int i = 0; i < n; i++) {
        mas[i] = new int[m];
        for(int j = 0; j < m; j++)
            mas[i][j] = new Random().Next(0, 10);
    }

    Console.WriteLine($"m = {m}, n = {n}");
    return mas;
}

int sumRowColArr(int[][] a1, int row, int[][] a2, int col)
{
    int  sum = 0;
    for (int i = 0; i < a1[0].Length; i++) {
        sum += a1[row][i] * a2[i][col];
    }
    return sum;
}

int[][]? matrixMull(int[][] m1, int[][] m2)
{
    if (m1[0].Length != m2.Length) {
        Console.WriteLine("Страшно ругаемсо!!");
        return null;
    }

    int n = m1.Length, m = m2[0].Length;
    int[][] res = new int[n][];
    for(int i = 0; i < n; i++) {
        res[i] = new int[m];
        for(int j = 0; j < m; j++)
            res[i][j] = sumRowColArr(m1, i, m2, j);
    }
    return res;
}

void printMass(int[][] mas)
{
    Console.WriteLine(string.Concat(System.Linq.Enumerable.Repeat("*", mas[0].Length * 3)));
    for(int i = 0; i < mas.Length; i++) {
        Console.WriteLine($"{string.Join(", \t", mas[i])}");
    }
}

int size = new Random().Next(1,10);
int[][] a, b;
int[][]? c;
a = genMas(size, new Random().Next(1,10)); 
b = genMas(new Random().Next(1,10), size);
c = matrixMull(a, b);
if (c != null) {
    printMass(a);
    printMass(b);
    printMass(c);
}
// int m = new Random().Next(1,10), n = new Random().Next(1,10);