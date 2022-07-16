Console.Clear();
void thirdnumber()
{
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    char[] M = inputLine.ToCharArray();

    if (inputLine.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine(M[2]);
    }
}

}
thirdnumber();

// 2 вариант
// Console.Clear();
// void thirdnumber()
// {
// int number = int.Parse(Console.ReadLine());
// int number2 = (number%10%10);
// int number3 = (number/100);

// if ( number3 == 0)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     else
//     {
//         Console.WriteLine("Третья цифра "+ number2);
//     }
// }
// thirdnumber();