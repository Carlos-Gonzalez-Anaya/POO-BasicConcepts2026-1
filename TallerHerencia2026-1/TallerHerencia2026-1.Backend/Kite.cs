

namespace TallerHerencia2026_1.Backend
{
    public class Kite:Rhombus
    {
        // Fields
        private double _b;

        // constructors
        public Kite(double _b, double _d1, double _d2, double _a):base(_d1,_d2,_a)
        {
            Name = "Kite";
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
            return base.GetArea();
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

            }
            return B;
        }
    }
}
