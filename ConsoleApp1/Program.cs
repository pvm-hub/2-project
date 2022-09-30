using System;

try
{
    int T = 2;
double m = 0.2;
Console.WriteLine("Введите A:");
double A = double.Parse(Console.ReadLine());
    double W = (2 * (Math.PI * Math.PI)) * (A * A) * m / (T * T);
    Console.WriteLine(Math.Round(W, 2));
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}