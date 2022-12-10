 //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите первое число");
int numbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numbers2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numbers3 = Convert.ToInt32(Console.ReadLine());
int max = numbers;

if (numbers2>numbers);
max = numbers2;
if (numbers3>numbers2);
max = numbers3;

Console.Write("Максимальное число ");
Console.WriteLine(max);