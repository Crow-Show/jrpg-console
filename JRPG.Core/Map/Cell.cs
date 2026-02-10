namespace JRPG.Core.Map;

internal class Cell
{
    public Coordinates Position { get; }
    public Surface Surface { get; }
    public EntityId? OccupantId { get; private set; }

    public Cell(Coordinates coordinates, Surface surface)
    {
        Position = coordinates;
        Surface = surface;
    }

    public void SetOccupant(EntityId id)
    {
        OccupantId = id;
    }
}