// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] getArr()
{
    int m = new Random().Next(1, 10);
    Console.WriteLine($"Введте {m} чисел");
    return new int[m]; 
}

int count = 0;
int[] arr = getArr();

for (int i = 0; i < arr.Length; i++) {
    int.TryParse(Console.ReadLine(), out arr[i]);
    if (arr[i] < 0)
       count++; 
}

Console.WriteLine($"{string.Join(", ", arr)} -> {count}");
 