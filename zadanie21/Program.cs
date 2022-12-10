// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int[][] points = new int[2][];
Console.WriteLine(points.Length);
Console.WriteLine("введите, пожалуйста, коордиаты двух точек.");
for (int i = 0; i < points.Length; i++) {
    string? s = Console.ReadLine();
    if (s == null) {
        Console.WriteLine("Ошибка!");
        return 1;
    }
    string[] nums = s.Split(",", 3);
    points[i] = new int[3];
    for (int j = 0; j < nums.Length; j++) {
        points[i][j] = int.Parse(nums[j]);
    }
}

float len = 0;
for (int i = 0; i < 3; i++) {
    int sub = points[0][i] - points[1][i];
    len += sub * sub;
}

len = float.Sqrt(len);
Console.WriteLine($"A({points[0][0]},{points[0][1]},{points[0][2]}); B({points[1][0]},{points[1][1]},{points[1][2]}) -> {len}");

return 0;