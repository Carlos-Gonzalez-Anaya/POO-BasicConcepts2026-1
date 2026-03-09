
namespace TallerHerencia2026_1.Backend
{
    public class Circle : GeometricFigure
    {
        //Fields
        private double _r;

        //Constructors
        public Circle(double _r)
        {
            Name = "Circle";
            R = _r;
        }

        //propierties
        public double R
        {
            get => _r;
            set => _r = value;
        }

        //Methods
        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        private double ValidateR(double _r)
        {
            if (R < 0)
            {
                throw new ArgumentException(nameof(R), "the radius of a circle cannot be 0");
            }
            return _r;

        }
    }
}
