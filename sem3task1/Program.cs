using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      if (number>9999 & number<100000)
      {
        int n = number;
        int reversed = 0;
        while (n>0)
        {
            int last = n%10;
            reversed=reversed*10+last;
            n=n/10;
        }
        return reversed==number;
      }
      else {
        Console.WriteLine("Число не пятизначное");
        return false;
        }
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 645467;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
