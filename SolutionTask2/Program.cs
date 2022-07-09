string? inputLine = Console.ReadLine();

if(inputLine != null)
{
//    switch (inputNumber)
//    {
//        case 1:
//        Consolr.WriteLine("Понедельник");
//        break;

//        case 2:
//        Consolr.WriteLine("Вторник");
//        break;
//    }
    int inputNumber = int.Parse(inputLine);
    string[] dayofWeek = new string[7];
    dayofWeek[0] = "Понедельник";
    dayofWeek[1] = "Вторник";
    dayofWeek[2] = "Среда";
    dayofWeek[3] = "Четверг";
    dayofWeek[4] = "Пятница";
    dayofWeek[5] = "Суббота";
    dayofWeek[6] = "Воскресенье";


    Console.WriteLine(dayofWeek[inputNumber-1]);
}
