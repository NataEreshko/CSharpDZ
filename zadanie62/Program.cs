// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[][] mas;

void printMass(in int[][] mas)
{
    Console.WriteLine(string.Concat(System.Linq.Enumerable.Repeat("*", mas[0].Length * 3)));
    for(int i = 0; i < mas.Length; i++)
        Console.WriteLine($"{string.Join(", \t", mas[i])}");
}

int currentDir = 0;

int[]? checDirect(int[][] mas, int x0, int y0)
{
	int[][] directs = new int[4][] {new int[2] {1,0}, new int[2]{0,1}, new int[2]{-1,0}, new int[2]{0,-1}};
	int x,y;
	int i = currentDir;
	while(true) {
		x = x0 + directs[i][0];
		y = y0 + directs[i][1];
		if (x < 0 || y < 0 || x >= mas[0].Length || y >= mas.Length || mas[y][x] != 0) {
			i++;
			if (i == directs.Length) {
				i = 0;
			}
			if (i == currentDir) {
				break;
			}
			continue;
		}

		currentDir = i;	

		return directs[i];
	}

	return null;
}


int n = new Random().Next(2, 10); 
int m = new Random().Next(2, 10);
mas = new int[n][] ;
for (int i = 0; i < n; i++)
    mas[i] = new int[m];


int  num = 0;
int x = 0, y = 0;

while(true) {
	num++;
	mas[y][x] = num;
	int[]? direct = checDirect(mas,x,y);
	if (direct == null)
		break;
	x += direct[0];
	y += direct[1];
}



printMass(mas);