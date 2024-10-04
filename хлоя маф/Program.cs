using System.Collections.Specialized;
using System.ComponentModel.Design;

try
{ 
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y:");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Значение радиуса:");
    double R = double.Parse(Console.ReadLine());
    if ((x * x + y * y) < R * R) Console.WriteLine("Находиться внутри окружности") ;
    else Console.WriteLine("Вне окружности");
}
catch
{
    Console.WriteLine("Error");
}

