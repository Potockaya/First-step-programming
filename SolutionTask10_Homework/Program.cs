Console.Clear();
void middleDigit() 
{
    int number = new Random().Next(100, 1000);
    Console.Write("Случайное трехзначное число : ");
    Console.WriteLine(number);

    int secondnum = (number % 100)/10;
    
    Console.Write("Вторая цифра: ");
    Console.Write(secondnum);        
}

middleDigit();