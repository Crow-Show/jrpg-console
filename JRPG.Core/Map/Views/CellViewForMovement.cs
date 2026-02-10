namespace JRPG.Core.Map.Views;

public class CellViewForMovement : ICellViewForMovement
{
    public bool IsPassable { get; }
    
    public CellViewForMovement(bool isPassable)
    {
        IsPassable = isPassable;
    }
}