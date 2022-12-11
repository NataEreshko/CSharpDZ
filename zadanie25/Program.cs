// Напишите цикл(программу), который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write($"Введите число A: ");
int A;
int.TryParse(Console.ReadLine(), out A);

Console.Write($"Введите число B: ");
int B;
int.TryParse(Console.ReadLine(), out B);

if (B <= 0){
    Console.WriteLine($"Неверное число B");
    return 1;

}

int result = 1;

for (int i = 0; i < B; i++) 
    result *= A;

Console.WriteLine($" {A} ^ {B} = {result} ");

return 0;
