// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void printMass(int[][] mas, int mer)
{
    Console.WriteLine(string.Concat(System.Linq.Enumerable.Repeat("*", mas[0].Length * 3)));
    for(int i = 0; i < mas.Length; i++) {
        for (int j = 0; j < mas[i].Length; j++) {
            if(j > 0) Console.Write(", ");
            Console.Write($"{mas[i][j]}({mer},{i},{j})");
        }
        Console.WriteLine("");
    }
}


Console.Write("Введите размер 3d-массива. (через запятую): ");
string? s = Console.ReadLine();
if(s == null) {
    return 1;
}

string[] sizesS = s.Split(",", 3);
int[] size = new int[sizesS.Length];
for( int i = 0; i < size.Length; i++ )
    size[i] = int.Parse(sizesS[i]);

Console.WriteLine($"размерность матрицы: {string.Join(",", size)}");
int [][][] mas = new int[size[0]][][];
for(int k = 0; k < size[0]; k++) {
    mas[k] = new int[size[1]][];
    for(int l = 0; l < size[1]; l++) {
        mas[k][l] = new int[size[2]];
        for(int m = 0; m < size[2]; m++) {
            mas[k][l][m] = new Random().Next(10,100);
        }
    }
}

for(int i = 0; i < mas.Length; i++)
    printMass(mas[i], i);
return 0;