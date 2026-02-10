namespace JRPG.Core.Domain;

public struct Coordinates
{
    public int X { get; }
    public int Y { get; }
    
    public Coordinates(int x, int y)
    {
        if (x < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(x), "Координата X не может быть отрицательной");
        }

        if (y < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(y), "Координата Y не может быть отрицательной");
        }
        
        X = x;
        Y = y;
    }
}