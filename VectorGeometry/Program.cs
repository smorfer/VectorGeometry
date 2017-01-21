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
            Vector v1 = new Vector(-2, 1, 0);
            Vector v2 = new Vector(-1, 0, 3);
            Vector vCross = Vector.CalculateCrossProduct(v2, v1);
            Vector vUnit = Vector.CalculateUnitVector(vCross);
            Console.WriteLine("[{0}, {1}, {2}]", vCross.X, vCross.Y, vCross.Z);
            Console.WriteLine("[{0}, {1}, {2}]", vUnit.X, vUnit.Y, vUnit.Z);
        }
    }
}
