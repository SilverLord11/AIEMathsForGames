using System;
using System.Collections.Generic;
using System.Text;

namespace VectorPractice
{
    class Vector3
    {
        public float x, y, z;
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
        static void Main()
        {

        }
    }
}
