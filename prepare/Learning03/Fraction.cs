// The purpose of the Fraction Class is to help me solidify my understanding
// of "Encapsulation".

public class Fraction
{
    // declaring the private member variables.
    private int _top;
    private int _bottom;

    // declaring the three different sets of constructors.
    public Fraction() 
    {
        _top = 1;
        _bottom = 1;
        
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // declaring the Getters and Setters for both top and bottom value.
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // creating 2 methods, one that display the fraction in string and the other in double(decimal)
    public string GetFractionString()
    {
        string stringFormat = $"{_top}/{_bottom}";
        return stringFormat;
    }

    public double GetDecimalValue()
    {
        double fract = (double)_top / (double)_bottom;
        return fract;
    }
}