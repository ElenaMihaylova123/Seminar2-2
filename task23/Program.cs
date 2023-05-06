//Задача 23
// Вводится число N. Нужно вывести куб каждого числа от 1 до N


Console.Write("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
    Console.Write(i * i * i + " ");
