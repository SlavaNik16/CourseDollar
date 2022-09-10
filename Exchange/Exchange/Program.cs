/*
ввести количество денег 1 валюты, вывести курс валюты 1 - 2, 
процент налога, если < 500 - 8, > 500 - 0.37%
*/
using System;
class Program
{
    public static void Main()
    {
        var run = true;
        while (run)
        {
            Console.Write("Введите количество долларов с переводом в рубли 1:60 : ");
            var dolInput = Console.ReadLine();
            run =  double.TryParse(dolInput, out double dolOutput);
            var result = dolOutput * 60;
            var proc = 0.37d;
            if (!run) 
            {
                break;
            }

            if (dolOutput < 500)
            {
                Console.WriteLine($"Взято {8} руб и получается: {(result - 8):#,###}");
            }
            else
            {
                Console.WriteLine($"Взято {proc}% и получается: {(result - (result * proc / 100)):#,###}");
            }
        }
    }
}
