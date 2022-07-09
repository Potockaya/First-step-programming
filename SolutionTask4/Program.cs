// string? inputLine = Console.ReadLine();

// if(inputLine != null)
// {
//     int inputNumber = int.Parse(inputLine);

//     int outputNumber = inputNumber%100;
   
//     Console.WriteLine(outputNumber);
// }
string? inputLine = Console.ReadLine();
if (inputLine !=null)
{
    string lastNum = inputLine.Substring(2,1);
    Console.WriteLine(lastNum);
}