// //Задача 66: Задайте значения M и N. 
// //Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int ColculateSum(int M, int N) {
    if(M > N) {
        return 0;
    }
    return M + ColculateSum(M + 1, N);
}

int ReadData(string name) {
    Console.Write($"Введите число {name}: ");
    return int.Parse(Console.ReadLine());
}

int M = ReadData("M");
int N = ReadData("N");
Console.WriteLine($"Сумма чисел от M = {M} до N = {N} равна {ColculateSum(M, N)}");