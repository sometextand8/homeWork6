double MakeDobFromStr(string message)
{
    Console.Write(message);
    double num = double.Parse(Console.ReadLine());
    return num;
}

double b1 = MakeDobFromStr("Введите значение b1: ");
double b2 = MakeDobFromStr("Введите значение b2: ");
double k1 = MakeDobFromStr("Введите значение k1: ");
double k2 = MakeDobFromStr("Введите значение k2: ");

double X = (b2 - b1) / (k2 - k1);
double Y = X * k2 + b2;

Console.WriteLine($"Координаты двух прямых{(X, Y)}");