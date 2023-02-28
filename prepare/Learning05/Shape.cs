using System;
// The base/parent class

public class Shape
{
    private string _color;

    public Shape (string color)
    {
        _color = color;
    }

    public void SetColor (string theColor)
    {
        _color = theColor;
    }

    public string GetColor ()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return 3.0;
    }
}