

namespace GeoClass_Lib 
{
    public class Triangle : IShape
    {
        public double Length { get; set;}
        public double Bottom { get; set;}


        public double Area()
        {
            return 05 * Bottom * Length;
        }

        public double Perimeter()
        {
            return 3 * Bottom;
        }
    }
}