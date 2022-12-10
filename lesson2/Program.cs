//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int numbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numbers2 = Convert.ToInt32(Console.ReadLine());

if (numbers>numbers2)
    {Console.WriteLine($"Число {numbers} больше {numbers2} ");}
    else
    {Console.WriteLine($"Число {numbers} меньше {numbers2} ");}
