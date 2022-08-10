// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int n = Convert.ToInt32(number);
if (n<100) Console.WriteLine("Третьей цифры нет");
else 
{
    char num = number[2];
    Console.WriteLine(num);
}


