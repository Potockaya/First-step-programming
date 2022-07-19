// // 1 вариант
// Console.Clear();
// void palindrom()
// {
// string? inputLine = Console.ReadLine();

// if (inputLine != null)
// {
//     char[] M = inputLine.ToCharArray();
//      if (inputLine.Length != 5)
//     {
//         Console.WriteLine("Число не пятизначное");
//     }
//     else
//     {
//         if (M[0]==M[4] && M[1]==M[3])
//         {
//         Console.WriteLine("Палиндром");
//         }
//         else
//         {
//         Console.WriteLine("Не палиндром");  
//         }
//     }
// }

// }
// palindrom();


//2 вариант
Console.Clear();
int number1;
int number2; 
int number3; 
int number4; 
int number5; 
void palindrom()
{
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    char[] M = inputLine.ToCharArray();
    if (inputLine.Length != 5)
    {
        Console.WriteLine("Число не пятизначное");
    }
    else
    {
        number1 = M[0];
        number2 = M[1];
        number3 = M[2];
        number4 = M[3];
        number5 = M[4];
        if (number1==number5 && number2==number4)
        {
        Console.WriteLine("Палиндром");
        }
        else
        {
        Console.WriteLine("Не палиндром");  
        }
    }
}

}
palindrom();

