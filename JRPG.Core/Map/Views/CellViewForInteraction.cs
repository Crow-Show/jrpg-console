namespace JRPG.Core.Map.Views;

public class CellViewForInteraction : ICellViewForInteraction
{
    public EntityId? OccupantId { get; }
    public SurfaceId? SurfaceId { get; }

    public CellViewForInteraction(EntityId? occupantId, SurfaceId? surfaceId)
    {
        OccupantId = occupantId;
        SurfaceId = surfaceId;
    }
}