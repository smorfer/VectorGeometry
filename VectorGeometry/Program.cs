using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(0, 2, 0);
            Vector v2 = new Vector(-3, 0, -2);
            Vector vCross = Vector.CalculateCrossProduct(v2, v1);
            Vector vUnit = Vector.CalculateUnitVector(v2);
            Vector vCrossAlt = Vector.CalculateCrossProduct(v1.CalculateMagnitude(), v2.CalculateMagnitude(), Math.Sin(Vector.ConvertDegreeToRadian(90)), vCross); 
            Console.WriteLine("[{0}, {1}, {2}]", vCross.X, vCross.Y, vCross.Z);
            Console.WriteLine("[{0}, {1}, {2}]", vCrossAlt.X, vCrossAlt.Y, vCrossAlt.Z);
            Console.WriteLine("[{0}, {1}, {2}]", vUnit.X, vUnit.Y, vUnit.Z);
        }
    }
}
