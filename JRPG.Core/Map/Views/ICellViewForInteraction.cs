namespace JRPG.Core.Map.Views;

public interface ICellViewForInteraction
{
    EntityId? OccupantId { get; }
    SurfaceId? SurfaceId { get; }
}