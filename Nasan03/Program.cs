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

static void RightTriangleArea(float a, float b)
{
    float square = a * b;
    Console.WriteLine($"{square / 2}");
}

RightTriangleArea(4, 3);

static void RightCircleArea(float a)
{
    Console.WriteLine($"{a * a * 3.14}");
}

RightCircleArea(3);

Console.ReadLine();