namespace JRPG.Core.Map.Views;

public class CellViewForUi : ICellViewForUi
{
    public Icon Icon { get; }
    
    public CellViewForUi(Icon icon)
    {
        Icon = icon;
    }
}