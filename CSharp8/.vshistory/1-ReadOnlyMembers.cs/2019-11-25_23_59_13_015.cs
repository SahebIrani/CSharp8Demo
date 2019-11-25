//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly#readonly-member-examples

namespace CSharp8
{
    public struct Rectangle
    {
        public double Length { get; set; }
        public double HeightAuto { readonly get; set; }

        private double _height;
        public double Height
        {
            readonly get => _height;
            set => _height = value;
        }

        public readonly double Area()
        {
            //HeightAuto += 1; ReadOnly
            return Length * Height;
        }
    }
}
