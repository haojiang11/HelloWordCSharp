using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordCSharp
{

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor
        public Point(double x, double y) => (X, Y) = (x, y);
        public double Distance => Math.Sqrt(X * X + Y * Y);

        public override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";

        // returns a tuple
        public (double, double) Flip()
        {
            return (Y, X);
        }
    }


    public record NamedPointRecord(string Name, int X, int Y);



}
