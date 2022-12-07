Console.Write("Введите координату X1: ");

int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1: ");

int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z1: ");

int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");

int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2: ");

int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z2: ");

int z2 = Convert.ToInt32(Console.ReadLine());

// Math.Sqrt (Извлекает квадратный корень из числа) Math.Sqrt(25) = 5

// Math.Pow (2, 3) => 8 = 2 * 2 * 2

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); // Math.Pow(Число, степень)

Console.WriteLine("Расстояние между 2 точками: " + Math.Round(d, 2)); // Math.Round(Число, кол-во знаков) - сокращает все, что после запятой.
