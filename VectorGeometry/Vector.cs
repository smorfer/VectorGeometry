using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGeometry
{
    class Vector
    {

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public double Z
        {
            get;
            set;
        }

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        

        public double CalculateMagnitude()
        {
            return Math.Sqrt(Math.Pow(X,2) + Math.Pow(Y,2) + Math.Pow(Z,2));
        }

        public static Vector operator+(Vector vectorA, Vector vectorB)
        {
            vectorA.X += vectorB.X;
            vectorA.Y += vectorB.Y;
            vectorA.Z += vectorB.Z;
            return vectorA;
        }
        public static Vector operator-(Vector vectorA, Vector vectorB)
        {
            vectorA.X -= vectorB.X;
            vectorA.Y -= vectorB.Y;
            vectorA.Z -= vectorB.Z;
            return vectorA;
        }

        public static Vector operator*(Vector vector, double scalar)
        {
            vector.X *= scalar;
            vector.Y *= scalar;
            vector.Z *= scalar;
            return vector;
        }

        public static Vector operator/(Vector vector, double scalar)
        {
            vector.X /= scalar;
            vector.Y /= scalar;
            vector.Z /= scalar;
            return vector;
        }

        public static Vector CalculateUnitVector(Vector vector)
        {
            return vector / vector.CalculateMagnitude();
        }

        public static double CalculateDotProduct(double magnitudeOfVectorA, double magnitudeOfVectorB, double cosinOfAngle)
        {
            return magnitudeOfVectorA * magnitudeOfVectorB * cosinOfAngle;
        }
        public static double CalculateDotProduct(Vector vectorA, Vector vectorB)
        {
            return vectorA.X * vectorB.X + vectorA.Y * vectorB.Y + vectorA.Z * vectorB.Z;
        }

        public static Vector CalculateCrossProduct(Vector vectorA, Vector vectorB)
        {
            double X1 = vectorA.Y * vectorB.Z - vectorA.Z * vectorB.Y;
            double X2 = vectorA.Z * vectorB.X - vectorA.X * vectorB.Z;
            double X3 = vectorA.X * vectorB.Y - vectorA.Y * vectorB.X;
            return new Vector(X1, X2, X3);
        }

        public static Vector CalculateCrossProduct(double magnitudeOfVectorA, double magnitudeOfVectorB, double sinOfAngle, Vector unitVector)
        {
            return unitVector * sinOfAngle * magnitudeOfVectorA * magnitudeOfVectorB;
        }

        public static double ConvertRadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        public static double ConvertDegreeToRadian(double angle)
        {
            return  Math.PI * (angle / 180.0);
        }

    }
}
