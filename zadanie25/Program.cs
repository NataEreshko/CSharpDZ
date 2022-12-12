// Напишите цикл(программу), который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int fillVar(string var)
{
    int V;
    Console.Write($"Введите число {var}: ");
    int.TryParse(Console.ReadLine(), out V);
    return V;
}

int calc(int a, int b)
{
    int result = 1;

    for (int i = 0; i < b; i++) 
        result *= a;
    return result;
}

int A = fillVar("A");
int B = fillVar("B");

if (B <= 0) {
    Console.WriteLine($"Неверное число B");
    return 1;
}

Console.WriteLine($" {A} ^ {B} = {calc(A, B)} ");

return 0;