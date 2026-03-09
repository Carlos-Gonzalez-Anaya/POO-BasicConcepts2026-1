
namespace TallerHerencia2026_1.Backend
{
    public class Parallelogram:Rectangle
    {
        //fields
        private double _h;

        // constuctors
        public Parallelogram (double _h, double _a, double _b):base(_a,_b)
        {
            Name = "Parallelogram";
            H= _h;
        }

        //Propieties
        public double H
        {
            get => _h;
            set => _h = value;
        }

        //Methods
        public override double GetArea()
        {
            return B*H;
        }

        public override double GetPerimeter()
        {
            return base.GetPerimeter();
        }

        private double ValidateH(double _b)
        {
            if (H < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(H), "one side cannot have length 0");

            }
            return H;
        }
    }
}
