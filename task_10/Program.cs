/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Enter a number =>  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"second number {(number % 100)/10}");
