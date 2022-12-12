//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).



Console.WriteLine("ВВедите число");
int digit1 = Convert.ToInt32(Console.ReadLine());
if (digit1 % 2 == 0)
{Console.WriteLine($"Число {digit1} четное");}
else 
{Console.WriteLine($"Число {digit1} нечетное");}
