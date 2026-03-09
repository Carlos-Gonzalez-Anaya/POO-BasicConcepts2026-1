
namespace TallerHerencia2026_1.Backend
{
    public class Rhombus:Square
    {
        //Fields
        private double _d1;
        private double _d2;

        // constructors
        public Rhombus(double _d1, double _d2, double _a):base(_a)
        {
            Name = "Rhombus";
            D1 = _d1;
            D2 = _d2;
        }

        //Propieties
        public double D1
        {
            get => _d1;
            set => _d1 = value;
        }

        public double D2
        {
            get => _d2;
            set => _d2 = value;
        }

        //Methods

        public override double GetArea()
        {
            return (D1*D2)/2;
        }

        public override double GetPerimeter()
        {
            return 4*A;
        }

        private double ValidateD1(double _d1)
        {
            if (D1 < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(D1), "one side cannot have length 0");

            }
            return D1;
        }

        private double ValidateD2(double _d2)
        {
            if (D2 < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(D2), "one side cannot have length 0");

            }
            return D2;
        }
    }
}
