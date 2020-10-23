using System;

namespace MathForGames
{
    class MathForGamesStart
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static float mathFunction(float x)
        {
            float result = x * x + 2 * x - 7;
            return result;
        }
        static float mathFunction(float a, float b, float c)
        {
            Math.Sqrt(b * b + 4 * a * c);
            float result = -b +- 2 * a;
            return result;
        }
    }
}
