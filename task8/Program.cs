Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
if (N >0)
{
    while (count <= N)
    { if(count%2 == 0) 
        {
            Console.Write(count +" ");
            count++;
        }
        else 
        {
            count++;
        }

    }
}
else 
{
    Console.WriteLine("Программа работает только с положительными числами!");
}
