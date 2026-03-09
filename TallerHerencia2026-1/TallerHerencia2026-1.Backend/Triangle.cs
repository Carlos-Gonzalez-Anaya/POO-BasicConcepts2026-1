
namespace TallerHerencia2026_1.Backend
{
    public class Triangle:Rectangle
    {
        //Fields 
        private double _c;
        private double _h;

        //constructor
        public Triangle(double _c, double _h,double _a, double _b):base(_a,_b)
        {
            Name = "Triangle";
            C = _c;
            H = _h;
        }

        //Propiets
        public double C
        {
            get => _c;
            set => _c = value;
        }

        public double H
        {
            get => _h;
            set => _h = value;
        }

        //Methods
        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A+B+C;
        }

        private double ValidateC(double _c)
        {
            if (C < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(C), "one side cannot have length 0");

            }
            return C;
        }

        private double ValidateH(double _h)
        {
            if (H < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(H), "one side cannot have length 0");

            }
            return H;
        }

    }
}
