// See https://aka.ms/new-console-template for more information

Console.Write("Введите количество месяцев с начала 1990 года: ");
int n = int.Parse(Console.ReadLine());

try
{
    int month = n % 12;
    int year = 1990 + n / 12;
    int day = 2;
    string monthName;


    switch (month)
    {
        case 1:
            monthName = "Январь";
            break;
        case 2:
            monthName = "Февраль";
            break;
        case 3:
            monthName = "Март";
            break;
        case 4:
            monthName = "Апрель";
            break;
        case 5:
            monthName = "Май";
            break;
        case 6:
            monthName = "Июнь";
            break;
        case 7:
            monthName = "Июль";
            break;
        case 8:
            monthName = "Август";
            break;
        case 9:
            monthName = "Сентябрь";
            break;
        case 10:
            monthName = "Октябрь";
            break;
        case 11:
            monthName = "Ноябрь";
            break;
        case 12:
            monthName = "Декабрь";
            break;
        default:
            monthName = "Неизвестный месяц";
            break;
    }
    bool isLeapYear = DateTime.IsLeapYear(year);
    string leapYearMessage = isLeapYear ? "високосный" : "невисокосный";
    Console.WriteLine($"Дата: {day} {monthName} {year} {leapYearMessage} год.");
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
