namespace JRPG.Core.Map.Views;

public class AdjacentCellsView
{
    public IReadOnlyList<Coordinates> Neighbors { get; }
    
    public AdjacentCellsView(IEnumerable<Coordinates> neighbors)
    {
        Neighbors = neighbors.ToList().AsReadOnly();
    }
}