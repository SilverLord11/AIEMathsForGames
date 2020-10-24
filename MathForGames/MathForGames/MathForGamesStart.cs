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

        static float mathfunction(float px, float py, float pz, float qx, float qy, float qz)
        {
            float result = px * qx + py * qy + pz * qz;
            return result;
        }

        static float mathFunction(float e, float f, float g, float h, float i, float j, float k)
        {
            float result = (float)((e * i + f * j + g * k + h) / Math.Sqrt(e * e + f * f + g * g));
            return result;
        }

        static float mathFunction(float t, float p0, float p1, float p2, float p3)
        {
            float result = (((1 - t) * (1 - t) * (1 - t)) * p0) + (3 * ((1 - t) * (1 - t)) * t * p1) + (3 * (1 - t) * t * t * p2) + (t * t * t * p3);
            return result;
        }
    }
}
