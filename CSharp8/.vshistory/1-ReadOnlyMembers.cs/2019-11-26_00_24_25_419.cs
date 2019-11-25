//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly#readonly-member-examples

namespace CSharp8
{
    public readonly struct Point
    {
        public Point(double x, double y) => (X, Y) = (x, y);
        public double X { get; }
        public double Y { get; }

        //public readonly double X;
        //public readonly double Y;

        public override string ToString() => $"({X}, {Y})";
    }

    public struct Rectangle
    {
        public double Length { get; set; }
        public double HeightAuto { readonly get; set; }

        private double _height;
        public /*readonly*/ double Height
        {
            readonly get
            {
                //HeightAuto += 1; //ReadOnly
                return _height;
            }

            set => _height = value; //ReadOnly if prop set
            //set { } // not useful, but legal
        }

        public readonly double Area()
        {
            //HeightAuto += 1; //ReadOnly
            return Length * Height;
        }
    }
}
