// Deriving class

public class Circle : Shape
{
    private float _radius;

    public Circle (float radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}