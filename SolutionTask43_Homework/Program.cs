//Ввод 4х глобальных переменных
Console.WriteLine("Введите коэффициент к1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент к2");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double b2 = double.Parse(Console.ReadLine());

// Решение задачи на пересечение прямых
void Decision()
{
    double x = 1;
    double y = k1 * x + b1;
    y = k2 * x + b2;

    // (y-b2)/k2=(y-b1)/k1;
    // k1*(y-b2)=k2*(y-b1);
    // (k1*y)-(k1*b2)=(k2*y)-(k2*b1);
    // (k1*y)-(k2*y)=(k1*b2)-(k2*b1);
    y = (k1 * b2 - k2 * b1) / (k1 - k2);
    x = (y - b1) / k1;
    Console.WriteLine("координата y = " + y);
    Console.WriteLine("координата x = " + y);
}
Decision();
