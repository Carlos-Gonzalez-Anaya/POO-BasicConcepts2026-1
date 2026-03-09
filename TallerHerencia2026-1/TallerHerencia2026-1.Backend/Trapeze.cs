

namespace TallerHerencia2026_1.Backend
{
    public class Trapeze : Triangle
    {
        //Fields
        private double _d;

        //constructors
        public Trapeze(double _d, double _a, double _b, double _c, double _h) : base(_a, _b, _c, _h)
        {
            Name = "Trapeze";
            D = _d;
        }

        //Propiets
        public double D
        {
            get => _d;
            set => _d = value;
        }

        //Methods

        public override double GetArea()
        {
            return ((B + D) * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }

        private double ValidateD(double _d)
        {
            if (D < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(D), "one side cannot have length 0");

            }
            return D;
        }

    }
}
