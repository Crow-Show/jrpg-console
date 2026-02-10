using System.Drawing;

namespace JRPG.Core.Map;

public struct Icon
{
    public char Symbol { get; }
    public ConsoleColor Color { get; }
    
    public Icon(char symbol, ConsoleColor color)
    {
        Symbol = symbol;
        Color = color;
    }
}