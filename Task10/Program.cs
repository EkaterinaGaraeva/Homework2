/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = new int();
Console.Write("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

number = number / 10;
int letter2 = number % 10;

Console.WriteLine($"Вторая цифра цисла: {letter2}");
