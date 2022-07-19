int coordXPointA;
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;
double lengthAB;

//Считывает координаты точек А и В
void readDataOfPoint()
{
    Console.WriteLine("Введите коррдинату X точки A");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите коррдинату Y точки A");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите коррдинату Z точки A");
    coordZPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите коррдинату X точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите коррдинату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите коррдинату Z точки B");
    coordZPointB = int.Parse(Console.ReadLine());
}

//Вычисляете расстояние между точками А и В
void conculateLengthAB()
{
lengthAB = Math.Round((Math.Sqrt(
    Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) +  Math.Pow((coordZPointA - coordZPointB), 2))),2);
}

readDataOfPoint();
conculateLengthAB();
Console.WriteLine(lengthAB);
