using System;

namespace MathForGames
{
    class MathForGamesStart
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static float mathFunction(float d)
        {
            float result = d * d + 2 * d - 7;
            return result;
        }
        static float mathFunction(float a, float b, float c)
        {
            Math.Sqrt(b * b + 4 * a * c);
            float result = (float)(-b +- Math.Sqrt(b * b + 4 * a * c) / 2 * a);
            return result;
        }

        static float MathFunction(float s, float e, float t)
        {
            float result = s + t * (e - s);
            return result;
        }

        static float mathFunction(float x1, float x2, float y1, float y2)
        {
            float result = (float)(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2- y1)));
            return result;
        }

    }
}
