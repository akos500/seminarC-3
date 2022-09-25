/*
Напишите программу, которая принимает на 
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i = i + 1)
{ 
    Console.Write($"{i*i*i} ");
}
