string? inputLine = Console.ReadLine();

if(inputLine != null)
{
   int inputNumber = int.Parse(inputLine);
   string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));
   Console.WriteLine(outDayOfWeek);
//    switch (inputNumber)
//    {
//        case 1:
//        Console.WriteLine("Понедельник");
//        break;

//        case 2:
//        Console.WriteLine("Вторник");
//        break;

//        case 3:
//        Console.WriteLine("Среда");
//        break;

//        case 4:
//        Console.WriteLine("Четверг");
//        break;

//        case 5:
//        Console.WriteLine("Пятница");
//        break;

//        case 6:
//        Console.WriteLine("Суббота");
//        break;

//        case 7:
//        Console.WriteLine("Воскресенье");
//        break;
//    }
//     // int inputNumber = int.Parse(inputLine);
//     // string[] dayofWeek = new string[7];
//     // dayofWeek[0] = "Понедельник";
//     // dayofWeek[1] = "Вторник";
//     // dayofWeek[2] = "Среда";
//     // dayofWeek[3] = "Четверг";
//     // dayofWeek[4] = "Пятница";
//     // dayofWeek[5] = "Суббота";
//     // dayofWeek[6] = "Воскресенье";


//    // Console.WriteLine(dayofWeek[inputNumber-1]);
}
