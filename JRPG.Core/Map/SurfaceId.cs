namespace JRPG.Core.Map;

public readonly record struct SurfaceId
{
    public int Id { get; }
    
    public SurfaceId(int id)
    {
        if (id < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(id));
        }
        
        Id = id;
    }
    
    public override string ToString() => Id.ToString();
}