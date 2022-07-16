Console.Clear();
int WeekNumber = int.Parse(Console.ReadLine());
if ( WeekNumber == 6 || WeekNumber == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    if (WeekNumber > 7 || WeekNumber <= 0)
{
    Console.WriteLine("Нет такого дня недели");
}
    else{
    Console.WriteLine("Рабочий день");
    }
    
}
