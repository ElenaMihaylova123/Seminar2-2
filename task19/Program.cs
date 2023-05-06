//Задача 19
//Проверить, является ли заданное пятизначное число палиндромом

Console.Write("Введи пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int oldValue = number;
int newValue = 0;
while (number > 0)
{
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
}
if (newValue == oldValue)
    Console.WriteLine("Это палиндром");
else
    Console.WriteLine("Это не палиндром");
