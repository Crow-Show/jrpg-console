namespace JRPG.Core.Map;

internal static class Surfaces
{
    public static readonly Surface Floor = new Surface(new SurfaceId(1), true, new Icon(' ', ConsoleColor.Black));
    public static readonly Surface Wall = new Surface(new SurfaceId(2), false , new Icon('#', ConsoleColor.White));

    private static readonly Dictionary<SurfaceId, Surface> ById = new()
    {
        {Floor.Id, Floor},
        {Wall.Id, Wall}
    };

    public static Surface GetSurface(SurfaceId id) => ById[id];
}