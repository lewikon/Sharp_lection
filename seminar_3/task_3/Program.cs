Console.WriteLine("Координату х первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координату y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координату х второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координату у второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
int distX = x1 - x2;
int distY = y1 - y2;
double hypotenuse = Math.Sqrt(distX*distX + distY*distY);
Console.WriteLine($"Расстояние между точками:{hypotenuse}");
