using JRPG.Core.Map.Views;

namespace JRPG.Core.Map;

internal class Map : IAdjacentCellsView
{
    private Cell[,] cells;

    public int Width => cells.GetLength(0);
    public int Height => cells.GetLength(1);

    private void CreateEmptyCells(int width, int height, Surface defaultSurface)
    {
        cells = new Cell [width, height];

        for (int y = 0; y < width; y++)
        {
            for (int x = 0; x < height; x++)
            {
                cells[y, x] = new Cell(new Coordinates(y, x), defaultSurface);
            }
        }
    }

    private bool IsInside(Coordinates pos)
    {
        return pos.X >= 0 && pos.X < Width && pos.Y >= 0 && pos.Y < Height;
    }
    
    // ---------------------------- Дописать методы Гет когда будет готов энтити

    public ICellViewForUi GetCellIcon(Coordinates pos)
    {
        var cell = cells[pos.Y, pos.X];

        Icon icon = cell.OccupantId == null
            ? Surfaces.GetSurface(cell.Surface.Id).Icon
            : Surfaces.Floor.Icon;
        
        return new CellViewForUi(icon);
    }

    public ICellViewForMovement GetCellPassable(Coordinates pos)
    {
        var cell = cells[pos.Y, pos.X];

        if (!IsInside(pos))
        {
            return new CellViewForMovement(false);
        }
        
        // тут нужен иф что Энтити на клетке и вернуть его проходимость
        
        return new CellViewForMovement(cell.Surface.IsPassable);
    }

    public ICellViewForInteraction GetOccupantId(Coordinates pos)
    {
        var cell = cells[pos.Y, pos.X];

        if (!IsInside(pos))
        {
            return new CellViewForInteraction(null, null);
        }

        return new CellViewForInteraction(cell.OccupantId, cell.Surface.Id);
    }

    public IEnumerable<Coordinates> GetAdjacentCells(Coordinates pos)
    {
        var deltas = new (int dx, int dy)[]
        {
            (0, -1),
            (0, 1),
            (-1, 0),
            (1, 0),
        };

        foreach (var (dx, dy) in deltas)
        {
            var neighbors = new Coordinates(pos.X + dx, pos.Y + dy);
            
            if (IsInside(neighbors))
            {
                yield return neighbors;
            }

            else
            {
                yield return pos;
            }
        }
    }
}