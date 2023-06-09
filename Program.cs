// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//пользовательский ввод
    Console.WriteLine("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());


double IntersectionX(double b_1, double k_1, double b_2, double k_2)
{
    double x = (b_2 - b_1) / (k_1 - k_2);
    x=Math.Round(x,2);
    return x;
}

double IntersectionY(double b_1, double k_1, double b_2, double k_2)
{
    double y = k_1 * IntersectionX(b_1, k_1, b_2, k_2) + b_1;
    y=Math.Round(y,2);
    return y;
}
double x=IntersectionX(b1,k1,b2,k2);
double y=IntersectionY(b1,k1,b2,k2);
Console.WriteLine($"({x}; {y})");



