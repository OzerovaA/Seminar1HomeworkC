﻿Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);
if (number1>=number2 && number1 >= number3)
{
    Console.WriteLine("Наибольшее из трёх чисел это: "+ number1);
}
else if (number2>=number1 && number2 >= number3)
{
    Console.WriteLine("Наибольшее из трёх чисел это: "+ number2);
}
else {Console.WriteLine("Наибольшее из трёх чисел это: "+ number3);}
