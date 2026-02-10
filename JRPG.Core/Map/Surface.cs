namespace JRPG.Core.Map;

internal class Surface
{
    public bool IsPassable { get; }
    public Icon Icon { get; }
    
    public SurfaceId Id { get; }

    public Surface(SurfaceId id, bool isPassable, Icon icon)
    {
        Id = Id;
        IsPassable = isPassable;
        Icon = icon;
    }
}