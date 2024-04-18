

namespace GeoClass_Lib
{
    public class Square : IShape
    {
        public double SideLength;

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double Area()
        {
            return SideLength * SideLength;
        }

        public double Perimeter()
        {
            return 4 * SideLength;
        }
    }
}