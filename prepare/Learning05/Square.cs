// derived class

public class Square : Shape
{
    private int _sides;

    public Square (int side, string color) : base(color)
    {
        _sides = side;
    }

    public override double GetArea()
    {
        return Math.Pow(_sides, 2);
    }
}