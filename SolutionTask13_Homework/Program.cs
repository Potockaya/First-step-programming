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