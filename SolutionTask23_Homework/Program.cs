Console.Clear();
string? inputLineN = Console.ReadLine();
if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);
    string lineN = string.Empty;
    string lineNcubed = string.Empty;
    int s = 1;
    while (s <= numberN)
    {
        lineN = lineN + s + "|";
        lineNcubed = lineNcubed + (s * s * s).ToString() + "|";
        s++;
    }
    Console.WriteLine(new string('-',lineNcubed.Length));
    Console.WriteLine(lineN);
    Console.WriteLine(lineNcubed);
    Console.WriteLine(new string('-',lineNcubed.Length));
}
