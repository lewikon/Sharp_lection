Console.WriteLine("Введите коэффициент х первого уравнения: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент х второго уравнения: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент смещения по оси у первого уравнения: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент смещения по оси у второго уравнения: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine(x + ";" + y);



