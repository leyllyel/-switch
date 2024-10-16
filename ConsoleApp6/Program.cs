// See https://aka.ms/new-console-template for more information

using System;

Console.Write("Введите количество месяцев с начала 1990 года: ");
int n = int.Parse(Console.ReadLine());

try
{
    int month = n % 12;
    int year = 1990 + n / 12;
    string monthName;
    int codeMonth =0;
    int day = 2;

    bool isLeapYear = DateTime.IsLeapYear(year);
    string leapYearMessage = isLeapYear ? "високосный" : "невисокосный";
    
    while(year < 2001)
    {
        year += 28;
    }
    int codeYear = year % 100;
    switch (month)
    {
        case 1:
            monthName = "Январь";
            if (isLeapYear == true)
            {
                codeMonth = 5;
            }
            else
            {
                codeMonth = 6;
            }
            break;
        case 2:
            monthName = "Февраль";
            if (isLeapYear == true)
            {
                codeMonth = 2;
            }
            else
            {
                codeMonth = 1;
            }
            break;
        case 3:
            monthName = "Март";
            codeMonth = 2;
            break;
        case 4:
            monthName = "Апрель";
            codeMonth = 5;
            break;
        case 5:
            monthName = "Май";
            codeMonth = 0;
            break;
        case 6:
            monthName = "Июнь";
            codeMonth = 3;
            break;
        case 7:
            monthName = "Июль";
            codeMonth = 5;
            break;
        case 8:
            monthName = "Август";
            codeMonth = 1;
            break;
        case 9:
            monthName = "Сентябрь";
            codeMonth = 4;
            break;
        case 10:
            monthName = "Октябрь";
            codeMonth = 6;
            break;
        case 11:
            monthName = "Ноябрь";
            codeMonth = 2;
            break;
        case 12:
            monthName = "Декабрь";
            codeMonth = 4;
            break;
        default:
            monthName = "Неизвестный месяц";
            break;
    }
    int dayOfWeek = ((day + codeMonth + codeYear) % 7);
   
    Console.WriteLine($"Дата: {day} {monthName}  {year} года, день недели: {dayOfWeek}, год: {leapYearMessage}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: Введено неверное значение. Пожалуйста, введите целое число.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Ошибка: Введенное значение выходит за пределы допустимого диапазона.");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}
