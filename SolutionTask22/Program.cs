﻿//2 вариант
List<int> listGen(int number) {
List<int> numbers = new List<int>();
for(int i = 1; i <= number; i++){
numbers.Add(i);
}
return numbers;
}

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
int inputNumber = int.Parse(inputLine);
List<int> nums = listGen(inputNumber);
foreach (var i in nums) {
Console.Write(i);
Console.Write(" ");
}
Console.WriteLine();
foreach (var i in nums) {
Console.Write(Math.Pow(i, 2));
Console.Write(" ");
}
}

//1 вариант
// string? inputLineN = Console.ReadLine();
// if (inputLineN != null)
// {
//     int numberN = int.Parse(inputLineN);
//     string lineN = "";
//     string lineNN = string.Empty;
//     int s = 1;
//     while (s <= numberN)
//     {
//         lineN = lineN + s + " ";
//         lineNN = lineNN + (s * s).ToString() + " ";
//         s++;
//     }
//     Console.WriteLine(lineN);
//     Console.WriteLine(lineNN);
// }
