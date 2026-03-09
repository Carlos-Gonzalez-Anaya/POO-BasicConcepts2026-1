namespace TallerHerencia2026_1.Backend
{
    public abstract class GeometricFigure
    {
        //
        // protected GeometricFigure(string name)
        //{
        //    Name = name;
        //}

        //propierties
        public string Name 
        { 
            get;
            set; 
        }

        //Methods

        public override string ToString()
        {
            return $"{GetArea}{GetPerimeter}";
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
