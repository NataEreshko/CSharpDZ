// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N больше 0: ");
int n;
int.TryParse(Console.ReadLine(), out n);

if (n <= 0){
    Console.WriteLine("неверное число");
    return 1;
}

string[] cubs = new string[n];
for (int i = 1; i <= n; i++) {
    cubs[i-1] = (i*i*i).ToString();
}

string result = string.Join(',', cubs);

Console.WriteLine($"{n} -> {result}");
return 0;