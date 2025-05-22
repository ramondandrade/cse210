using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

public class Fraction
{

    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1; // Default denominator should not be zero
    }

    public Fraction(int wholeNumer)
    {
        _top = wholeNumer;
        _bottom = 1; // Whole number has a denominator of 1
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


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

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
    










}

