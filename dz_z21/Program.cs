Console.WriteLine("Введите x1:");
var x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y1:");
var y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z1:");
var z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x2:");
var x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y2:");
var y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z2:");
var z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) +
                            Math.Pow(y2 - y1, 2) +
                            Math.Pow(z2 - z1, 2));
Console.WriteLine("\n" + distance.ToString("N2"));
