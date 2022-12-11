// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

string toSre(int[] arr) {
    string s = "";
    for (int i = 0; i < arr.Length; i++){
        if (i > 0) {
            s += ", ";
        }
        s += arr[i].ToString();
    }
    return s;
}

int n = 8;
int[] mas = new int[n];
for (int i = 0; i < n; i++)
    mas[i] = new Random().Next(2,4);

string res = toSre(mas);
Console.WriteLine( $"{res} -> [{res}]");