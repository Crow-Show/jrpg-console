namespace JRPG.Core.Map.Views;

public interface IAdjacentCellsView
{
    IEnumerable<Coordinates> GetAdjacentCells(Coordinates pos);
}