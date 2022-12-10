// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool err = false;
string? num;
do {
    if (err) {
        Console.WriteLine("ругаемсо!!!");
    } 
    Console.Write($"Введите 5и значное число: ");
    
    num = Console.ReadLine();
    err = true;
} while(num == null || num.Length != 5);

int len = num.Length;
bool isPalin = true;
for (int i = 0; i < len / 2; i++) {
    if (num[i] != num[len - i - 1]) {
        isPalin = false;
        break;
    }
}
string result = isPalin ? "Да" : "нет";
Console.WriteLine($"{num} -> {result}");
