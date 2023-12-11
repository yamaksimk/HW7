Console.Clear();

// void Recursion(int N, int M)
// {
//     if (N < M)
//         return;
//     else
//     {
//         Recursion(N - 1, M);
//         Console.Write(N + " ");
//     }
// }

// Console.Write("Введите M: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine());

// Recursion(N, M);

//..............................................................................................................................

// int FuncAccerman(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else if (m == 0)
//         return FuncAccerman(n - 1, 1);
//     else
//         return FuncAccerman(n - 1, FuncAccerman(n, m - 1));
// }

// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// int a = FuncAccerman(n, m);
// Console.Write(a);

//..............................................................................................................................

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         array[i] = new Random().Next(-10, 11);
// }


// void PrintNewArray(int[] array, int arrLength)
// {
//     if (arrLength == 0)
//         return;
//     Console.Write($"{array[arrLength - 1]} \t");
//     PrintNewArray(array, arrLength - 1);
// }

// Console.Write("Введите колличество элементов: ");
// int[] arr = new int[int.Parse(Console.ReadLine())];
// InputArray(arr);
// Console.WriteLine($"Исходный массив: {string.Join("\t", arr)}");
// Console.Write("Перевернутый массив: ");
// PrintNewArray(arr, arr.Length);