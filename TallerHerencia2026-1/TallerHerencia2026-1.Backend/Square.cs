

namespace TallerHerencia2026_1.Backend
{
    public class Square : GeometricFigure
    {
        //Fields
        private double _a;

        //Constructors
        public Square(double _a)
        {
            Name = "Square";
            A = _a;
        }

        //Propieties
        public double A 
        { 
            get => _a; 
            set => _a = value; 
        }


        //Methods

        public override double GetArea()
        {
            return A * A;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        private double ValidateA(double A)
        {
            if (A < 0)
            {
                throw new ArgumentException(nameof(A), "one side cannot have length 0");

            }return A;
        }
    }
}
