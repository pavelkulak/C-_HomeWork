// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8
// Console.Write("Введите число - ");
// int N = int.Parse(Console.ReadLine());
// int[] mass = new int[N];
// // //if (N % 2 == 0)
// // //{
// for (int i = 1; i < N - 1; i += 2)
// {
//     mass[i] = i + 1;

// }
// for (int i = 1; i < N - 1; i += 2)
// {
//     Console.Write(mass[i]);
// }

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int[] mass = new int[N];

for (int i = 1; i < N - 1; i += 2)
{
    mass[i] = i + 1;
}

Console.WriteLine("Массив от 1 до N:");
string joinedString = string.Join(", ", mass);
Console.WriteLine(joinedString);