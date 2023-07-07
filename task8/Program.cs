Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Чётные числа от 1 до {0}:", N);
        for (int i = 2; i <= N; i += 2)
        {
            Console.WriteLine(i);
        }