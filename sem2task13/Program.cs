Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number>=100)
{
    while (number>999)
    {
        number = number/10;
    }

Console.WriteLine(number%10);
}
else if (number <100)
{Console.WriteLine("Третьей цифры нет");}

