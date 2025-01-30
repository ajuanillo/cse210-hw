public class Fraction
{
    private int _top;
    private int _bottom;
public Fraction()
{
    //Default Value
    _top=1;
    _bottom=1;
    //Console.WriteLine($"Top: {_top} Bottom:{_bottom}"); //trying values
}
public Fraction(int topWhole)
{
    _top=topWhole;
    _bottom=1;
    //Console.WriteLine($"Top: {_top} Bottom:{_bottom}"); //trying values
}
public Fraction(int top,int bottom)
{
    _top=top;
    _bottom=bottom;
    //Console.WriteLine($"Top: {_top} Bottom:{_bottom}"); //trying values
}
public string GetFractionString()
{
    return _top+"/"+_bottom;
}
public double GetDecimalValue()
{
    double decim=(double)_top/(double)_bottom;
    return decim;
}
}