// static void Hello32()
// {
//     for (int i = 0; i < 32; i++)
//     {
//         Console.WriteLine("Hello, World!");
//     }
// }

// Hello32();

// static void Kvadrat(int square)
// {
//     Console.WriteLine($"{square * square}");
// }

// Kvadrat(5);

// static void Multi(float a, float b)
// {
//     Console.WriteLine($"{a * b}");
// }

// Multi(3.74f, 87.2f);

// static float RightTriangleArea(float a, float b)
// {
//     float result = (a * b)/2;
//     Console.WriteLine($"{result}");
//     return result;
// }

// RightTriangleArea(4, 3);

// static double RightCircleArea(double a)
// {
//     double result = a * a * 3.14;
//     Console.WriteLine($"{result}");
//     return result;
// }

static double GetNumberInput()
{
    while (true)
    {
        Console.WriteLine("Skriv ett tal");
        string tal = Console.ReadLine();
        double f;
        bool lyckad = double.TryParse(tal, out f);

        if (lyckad == true)
        {
            Console.WriteLine("Bra jobbat gullunge");
            return f;
        }
        else if (lyckad == false)
        {
            Console.WriteLine("Nej du har fel det är inget tal");
        }
    }
}

double r = GetNumberInput();

static double RightCircleArea(double a)
{
    double result = a * a * 3.14;
    Console.WriteLine($"{result}");
    return result;
}

RightCircleArea(r);

Console.ReadLine();