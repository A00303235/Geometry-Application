

namespace GeoClass_Lib
{
    public class Rectangle : IShape
    {
        public readonly double Length;
        public readonly double Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return 2 * (Length + Width);
        }
    }

}