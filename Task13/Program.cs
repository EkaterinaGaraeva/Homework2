/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int number = 32679;
int num = number;

if ((number / 100) > 0)
{
    while ((num / 1000) > 0)
    {
        num = num / 10;
    }
    int letter3 = num % 10;
    Console.WriteLine($"Третья цифра числа {number} - {letter3}");
}

else 
{
    Console.WriteLine("Третьей цифры нет");
}
