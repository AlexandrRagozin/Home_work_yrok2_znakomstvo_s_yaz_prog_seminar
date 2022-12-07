Console.Write("Введите число N: ");

int finish = Convert.ToInt32(Console.ReadLine());

for (int start = 1; start <= finish; start++)
{
    Console.Write(Math.Pow(start,3) + " ");
}