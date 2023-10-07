Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);
if(number>0 & number<8)
{
    if (number==6 | number==7)
    {
        Console.WriteLine("День недели - выходной");
    }
    else {Console.WriteLine("День недели - не выходной");}
}
else {Console.WriteLine("Такого дня недели не существует!");}