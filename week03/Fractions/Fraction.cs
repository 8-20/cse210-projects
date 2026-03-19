using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() 
    {
        // Default 1/1
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

    public string GetFractionString()
    {
        // Notice this is not stored as a number variable.
        // It is just a temporary local variable that will be recomputed each time this is called
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice this is not stored as a member variable
        // It will be recomputed each time this is called
        return (double)_top / (double)_bottom;
    }

}