// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Please, enter number (1-7):");
int number = Convert.ToInt32(Console.ReadLine());
if (number<1 || number>7) Console.WriteLine("Incorrect! Please, enter correct number");
else if (number>5 && number<=7) Console.WriteLine("Dayoff!");
else Console.WriteLine("Work!");
