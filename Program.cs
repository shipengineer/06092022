
/*
int CheckChetvert(int x, int y)
{
    int res;
    if (x > 0 && y > 0) res = 1;
    else if (x > 0 && y < 0) res = 4;
    else if (x < 0 && y < 0) res = 3;
    else if (x < 0 && y > 0) res = 2;
    else res = 0;
    return res;
}

try
{
    Console.Write("Введите координату х ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y ");
    int y = Convert.ToInt32(Console.ReadLine());
    int rez = CheckChetvert(x, y);
    if (rez != 0) Console.WriteLine($"Точка находится в четверти №  {rez}");
    else Console.WriteLine("Точка находится лежит на какой-то оси");
}
catch
{
    Console.WriteLine("Надо было вводить именно целые числа");
}
*/
// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
/*
double distance(int Ax, int Ay, int Bx, int By)
{
    int X = Ax - Bx;
    int Y = Ay - By;
    double distance = Math.Sqrt(Y * Y + X * X);
    return distance;
}


Console.Write("Введите координату х первой точки = ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у первой точки = ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х второй точки = ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второй точки = ");
int By = Convert.ToInt32(Console.ReadLine());

double L = distance(Ax, Ay, Bx, By);
System.Console.WriteLine(Math.Round(L, 3));








*/

// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
/*
string squareTable(int num)
{
    string result = $"{num} -> 1";

    for (int i = 2; i <= num; i++)
    {
        result = result + $", {Math.Pow(i, 2)}";

    }

    return result;
}

try
{
    System.Console.Write("Введите число = ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    System.Console.WriteLine(squareTable(num));


}
catch
{
    System.Console.WriteLine("Вводите целочисленное значение");
}
*/