/*
ввести количество денег 1 валюты, вывести курс валюты 1 - 2, 
процент налога, если < 500 - 8, > 500 - 0.37%
*/
{
    string dol;
    Console.Write("Введите количество долларов с переводом в рубли 1:60 : ");
    dol = Console.ReadLine();
    int.TryParse(dol, out int rub);
    var result = rub * 60;
    var proc = 0.37;
    Console.WriteLine($"Всего рублей: {result:#,###}");
    if (rub < 500) Console.WriteLine($"Взято {8} руб и получается: {(result - 8):#,###}");
    else Console.WriteLine($"Взято {proc}% и получается: {(result - (result * proc / 100)):#,###}");
}