// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
float[] getLine(int index)
{
    float[] line = new float[2];
    Console.Write($"Введите коэффициент k{index}: ");
    float.TryParse(Console.ReadLine(), out line[0]);
    Console.Write($"Введите коэффициент b{index}: ");
    float.TryParse(Console.ReadLine(), out line[1]);
    return line;
}

float[] l1 = getLine(1);
float[] l2 = getLine(2);

float x, y1, y2;

x = (l2[1] - l1[1]) / (l1[0] - l2[0]);
y1 = l1[0] * x + l1[1];
y2 = l2[0] * x + l2[1];
Console.WriteLine($"b1 = {l1[1]}, k1 = {l1[0]}, b2 = {l2[1]}, k2 = {l2[0]} -> ({x}; {y1}) "); 
Console.WriteLine($"проверка  {y1} = {y2} "); 
