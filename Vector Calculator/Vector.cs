using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public double x;
        public double y;
        public double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public double GetMagnitude()
        {
            // sqrt(x^2 + y^2 + z^2) = 3.74165
            return (Math.Sqrt(x * x + y * y + z * z));
        }

        public double GetDirection()
        {
            // atan(1/2) * 180 / pi = 26.56505
            return (double)(MathF.Atan((float)(x / y)) * 180 / Math.PI);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            //<1, 2, 3> + <-1, 2, -3> = <0, 4, 0>
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v)
        {
            return new Vector(v.x * -1, v.y * -1, v.z * -1);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            //<1, 2, 3> - <-1, 2, -3> = <2, 0, 6>
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v, double scalar)
        {
            return new Vector(v.x * scalar, v.y * scalar, v.z * scalar);
        }

        public static Vector Normalize(Vector v)
        {
            // <1, 2, 3> / mag = 1
            return new Vector(v.x / v.GetMagnitude(), v.y / v.GetMagnitude(), v.z / v.GetMagnitude());
        }

        public static double DotProduct(Vector v1, Vector v2)
        {
            // (1 * -1) + (2 * 2) + (3 * -3) = -6
            return (double)((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            return new Vector((v1.y * v2.z) - (v1.z * v2.y),
                (v1.z * v2.x) - (v1.x * v2.z),
                (v1.x * v2.y) - (v1.y * v2.x));
        }

        public static double AngleBetween(Vector v1, Vector v2)
        {
            return (Math.Acos(DotProduct(v1, v2) / (v1.GetMagnitude() * v2.GetMagnitude())));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2 )
        {
            double projectScalar = Vector.DotProduct(v1, v2) / Math.Pow(v2.GetMagnitude(), 2);
            return Vector.Scale(v2, projectScalar);
        }
    }
}
