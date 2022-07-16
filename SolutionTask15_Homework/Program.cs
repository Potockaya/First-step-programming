//  1 вариант

// Console.Clear();
// int WeekNumber = int.Parse(Console.ReadLine());
// if ( WeekNumber == 6 || WeekNumber == 7)
// {
//     Console.WriteLine("Выходной");
// }
// else
// {
//     if (WeekNumber > 7 || WeekNumber <= 0)
// {
//     Console.WriteLine("Нет такого дня недели");
// }
//     else{
//     Console.WriteLine("Рабочий день");
//     }

// }

//2  вариант
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    string outDayOfWeek = System.Globalization.CultureInfo
        .GetCultureInfo("ru-RU")
        .DateTimeFormat.GetDayName(
            (DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber)
        );
    if (inputNumber == 5 || inputNumber == 6)
    {
        Console.WriteLine(outDayOfWeek +" это выходной день");
    }
    else
    {
       Console.WriteLine(outDayOfWeek + " это рабочий день");
    }
}
