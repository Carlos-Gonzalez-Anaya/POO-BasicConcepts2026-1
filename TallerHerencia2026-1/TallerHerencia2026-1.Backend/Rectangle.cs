
using System.Reflection.Metadata.Ecma335;

namespace TallerHerencia2026_1.Backend
{
    public class Rectangle : Square
    {
        //fields
        private double _b;

        //constructors
        public Rectangle(double _a,double _b):base(_a)
        {
            Name = "Rectangle";
            B = _b;
        }

        //Propieties
        public double B
        {
            get => _b;
            set => _b = value;
        }

        //Methods

        public override double GetArea()
        {
            return A*B;
        }

        public override double GetPerimeter()
        {
            return 2*(A+B);
        }

        private double ValidateB(double _b)
        {
            if (B < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(B), "one side cannot have length 0");

            }return B;
        }
       

    }
}
